using System.Net;
using System.Text.Json;
using TesteDS.Domain.Utils;

namespace TesteDS.API.Utils
{
    public class CustomMiddleware
    {
        private readonly RequestDelegate _next;

        public CustomMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";

            if (exception is CustomException)
            {
                var customResponse = new
                {
                    Message = exception.Message,
                };

                context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return context.Response.WriteAsync(JsonSerializer.Serialize(customResponse));
            }
            var response = new
            {
                Message = "Ocorreu um erro interno no servidor.",
                Error = exception.Message,
#if DEBUG
                Details = exception.StackTrace
#endif
            };

            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            return context.Response.WriteAsync(JsonSerializer.Serialize(response));
        }

    }
}
