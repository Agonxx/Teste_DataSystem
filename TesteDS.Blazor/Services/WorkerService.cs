using Domain.Dtos;
using Domain.Models;
using TesteDS.Blazor.Services.Interfaces;
using TesteDS.Blazor.Utils;

namespace TesteDS.Blazor.Services
{
    public class WorkerService : IWorkerService
    {
        private readonly HttpClientService _httpClientService;

        public WorkerService(HttpClientService httpClientService)
        {
            _httpClientService = httpClientService;
        }

        public async Task<List<WorkerDto>> GetAll()
        {
            var obj = await _httpClientService
                                    .GetAsync<List<WorkerDto>>($"Worker/{WorkerRoutesApi.GetAll}");
            return obj.Dados;
        }

    }

}
