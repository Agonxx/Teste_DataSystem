using TesteDS.Blazor.Services.Interfaces;
using TesteDS.Blazor.Utils;
using TesteDS.Domain.Dtos;
using TesteDS.Domain.Models;

namespace TesteDS.Blazor.Services
{
    public class TaskItemService : ITaskItemService
    {
        private readonly HttpClientService _httpClientService;

        public TaskItemService(HttpClientService httpClientService)
        {
            _httpClientService = httpClientService;
        }

        public async Task<bool> Create(TaskItemDto taskItemObj)
        {
            var obj = await _httpClientService
                                    .PostAsync<bool>(taskItemObj, $"TaskItem/{TaskItemRoutesApi.Create}");
            return obj.Dados;
        }

        public async Task<TaskItemDto> GetById(int taskId)
        {
            var obj = await _httpClientService
                                    .AddParamQuery(nameof(taskId), taskId)
                                    .GetAsync<TaskItemDto>($"TaskItem/{TaskItemRoutesApi.GetById}");
            return obj.Dados;
        }

        public async Task<List<TaskItemDto>> GetAll()
        {
            var obj = await _httpClientService
                                    .GetAsync<List<TaskItemDto>>($"TaskItem/{TaskItemRoutesApi.GetAll}");
            return obj.Dados;
        }

        public async Task<bool> Update(TaskItemDto taskItemObj)
        {
            var obj = await _httpClientService
                                    .PutAsync<bool>($"TaskItem/{TaskItemRoutesApi.Update}", taskItemObj);
            return obj.Dados;
        }
        
        public async Task<bool> UpdateStatus(TaskItemDto taskItemObj)
        {
            var obj = await _httpClientService
                                    .PutAsync<bool>($"TaskItem/{TaskItemRoutesApi.UpdateStatus}", taskItemObj);
            return obj.Dados;
        }

        public async Task<bool> DeleteById(int taskId)
        {
            var obj = await _httpClientService
                                    .AddParamQuery(nameof(taskId), taskId)
                                    .DeleteAsync<bool>($"TaskItem/{TaskItemRoutesApi.DeleteById}");
            return obj.Dados;
        }
    }

}
