using Domain.Dtos;
using TesteDS.API.Infrastructure.Repositories;

namespace TesteDS.API.Application
{
    public class TaskItemService
    {
        private readonly TaskItemRepository _taskItemRepository;

        public TaskItemService( TaskItemRepository taskItemRepository)
        {
            _taskItemRepository = taskItemRepository;
        }

        public async Task<bool> Create(TaskItemDto taskItemObj)
        {
            var obj = await _taskItemRepository.Create(taskItemObj);
            return obj;
        }

        public async Task<TaskItemDto> GetById(int taskId)
        {
            var obj = await _taskItemRepository.GetById(taskId);
            return obj;
        }
        
        public async Task<List<TaskItemDto>> GetAll()
        {
            var obj = await _taskItemRepository.GetAll();
            return obj;
        }

        public async Task<bool> Update(TaskItemDto taskItemObj)
        {
            var obj = await _taskItemRepository.Update(taskItemObj);
            return obj;
        }
        
        public async Task<bool> UpdateStatus(TaskItemDto taskItemObj)
        {
            var obj = await _taskItemRepository.UpdateStatus(taskItemObj);
            return obj;
        }

        public async Task<bool> DeleteById(int taskId)
        {
            var obj = await _taskItemRepository.DeleteById(taskId);
            return obj;
        }
    }
}
