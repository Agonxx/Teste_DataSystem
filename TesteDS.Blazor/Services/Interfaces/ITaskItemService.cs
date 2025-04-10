using Domain.Dtos;

namespace TesteDS.Blazor.Services.Interfaces
{
    public interface ITaskItemService
    {
        Task<bool> Create(TaskItemDto taskItemObj);
        Task<TaskItemDto> GetById(int taskId);
        Task<List<TaskItemDto>> GetAll();
        Task<bool> Update(TaskItemDto taskItemObj);
        Task<bool> UpdateStatus(TaskItemDto taskItemObj);
        Task<bool> DeleteById(int taskId);
    }
}
