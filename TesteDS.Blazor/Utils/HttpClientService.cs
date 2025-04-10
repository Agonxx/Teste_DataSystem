using System.Text;
using Newtonsoft.Json;

namespace TesteDS.Blazor.Utils
{
    public class HttpClientService : IDisposable
    {
        private readonly HttpClient _client;
        private readonly ILogger<HttpClientService> _logger;
        private string _url = string.Empty;
        private readonly List<string> _parametros = new List<string>();
        private bool _disposed = false;

        public HttpClientService(HttpClient client, ILogger<HttpClientService> logger = null)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
            _logger = logger;
        }

        public void SetToken(string token)
        {
            if (string.IsNullOrEmpty(token))
            {
                _logger?.LogWarning("Tentativa de definir token vazio");
                return;
            }

            lock (_client)
            {
                if (_client.DefaultRequestHeaders.Contains("Authorization"))
                    _client.DefaultRequestHeaders.Remove("Authorization");

                _client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            }
        }

        public HttpClientService AddParamQuery(string name, object value)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException(nameof(name));

            _parametros.Add($"{name}={Uri.EscapeDataString(value?.ToString() ?? string.Empty)}");
            return this;
        }

        private void MontarUrl(string controller, params object[] parametros)
        {
            if (string.IsNullOrEmpty(controller))
                throw new ArgumentNullException(nameof(controller));

            var paramsPath = parametros != null && parametros.Length > 0
                ? "/" + string.Join('/', parametros)
                : string.Empty;

            _url = controller + paramsPath;

            if (_parametros.Count > 0)
            {
                _url += "?" + string.Join('&', _parametros);
            }

            _url = _url.TrimEnd('/');
            _logger?.LogDebug($"URL montada: {_url}");
        }

        public async Task<ApiResponse<T>> GetAsync<T>(string controller, CancellationToken cancellationToken = default, params object[] parametros)
        {
            try
            {
                var response = await GetAsync(controller, cancellationToken, parametros);
                _parametros.Clear();

                return await ProcessarResposta<T>(response);
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, $"Erro ao executar GET para {controller}");
                return ApiResponse<T>.Erro("Erro ao executar a solicitação", ex);
            }
        }

        public async Task<HttpResponseMessage> GetAsync(string controller, CancellationToken cancellationToken = default, params object[] parametros)
        {
            MontarUrl(controller, parametros);
            return await _client.GetAsync(_url, cancellationToken);
        }

        public async Task<ApiResponse<T>> PostAsync<T>(object obj, string controller, CancellationToken cancellationToken = default, params object[] parametros)
        {
            try
            {
                var response = await PostAsync(obj, controller, cancellationToken, parametros);
                return await ProcessarResposta<T>(response);
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, $"Erro ao executar POST para {controller}");
                return ApiResponse<T>.Erro("Erro ao executar a solicitação", ex);
            }
        }

        public async Task<HttpResponseMessage> PostAsync(object obj, string controller, CancellationToken cancellationToken = default, params object[] parametros)
        {
            MontarUrl(controller, parametros);
            var content = obj != null
                ? new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json")
                : null;

            return await _client.PostAsync(_url, content, cancellationToken);
        }

        public async Task<ApiResponse<T>> PutAsync<T>(string controller, object obj, CancellationToken cancellationToken = default, params object[] parametros)
        {
            try
            {
                var response = await PutAsync(controller, obj, cancellationToken, parametros);
                return await ProcessarResposta<T>(response);
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, $"Erro ao executar PUT para {controller}");
                return ApiResponse<T>.Erro("Erro ao executar a solicitação", ex);
            }
        }

        public async Task<HttpResponseMessage> PutAsync(string controller, object obj, CancellationToken cancellationToken = default, params object[] parametros)
        {
            MontarUrl(controller, parametros);
            var content = obj != null
                ? new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json")
                : null;

            return await _client.PutAsync(_url, content, cancellationToken);
        }

        public async Task<ApiResponse<T>> DeleteAsync<T>(string controller, CancellationToken cancellationToken = default, params object[] parametros)
        {
            try
            {
                var response = await DeleteAsync(controller, cancellationToken, parametros);
                return await ProcessarResposta<T>(response);
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, $"Erro ao executar DELETE para {controller}");
                return ApiResponse<T>.Erro("Erro ao executar a solicitação", ex);
            }
        }

        public async Task<HttpResponseMessage> DeleteAsync(string controller, CancellationToken cancellationToken = default, params object[] parametros)
        {
            MontarUrl(controller, parametros);
            return await _client.DeleteAsync(_url, cancellationToken);
        }

        private async Task<ApiResponse<T>> ProcessarResposta<T>(HttpResponseMessage response)
        {
            var content = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                try
                {
                    var resultado = ValidaTipoString<T>(content);
                    return ApiResponse<T>.SucessoRequest(resultado);
                }
                catch (JsonException ex)
                {
                    _logger?.LogError(ex, "Erro ao deserializar resposta");
                    return ApiResponse<T>.Erro("Erro ao processar a resposta", ex);
                }
            }

            _logger?.LogWarning($"Resposta com erro: {response.StatusCode} - {content}");
            return ApiResponse<T>.Erro($"Erro da API: {response.StatusCode}", statusCode: (int)response.StatusCode, mensagemApi: content);
        }

        private T ValidaTipoString<T>(string content)
        {
            if (typeof(T) == typeof(string))
                return (T)(object)content;

            if (string.IsNullOrEmpty(content))
                return default;

            return JsonConvert.DeserializeObject<T>(content);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                    _parametros.Clear();

                _disposed = true;
            }
        }
    }

    public class ApiResponse<T>
    {
        public bool Sucesso { get; private set; }
        public T Dados { get; private set; }
        public string Mensagem { get; private set; }
        public Exception Excecao { get; private set; }
        public int StatusCode { get; private set; }
        public string MensagemApi { get; private set; }

        private ApiResponse() { }

        public static ApiResponse<T> SucessoRequest(T dados, string mensagem = "Operação realizada com sucesso")
        {
            return new ApiResponse<T>
            {
                Sucesso = true,
                Dados = dados,
                Mensagem = mensagem,
                StatusCode = 200
            };
        }

        public static ApiResponse<T> Erro(string mensagem, Exception excecao = null, int statusCode = 500, string mensagemApi = null)
        {
            return new ApiResponse<T>
            {
                Sucesso = false,
                Mensagem = mensagem,
                Excecao = excecao,
                StatusCode = statusCode,
                MensagemApi = mensagemApi
            };
        }
    }
}