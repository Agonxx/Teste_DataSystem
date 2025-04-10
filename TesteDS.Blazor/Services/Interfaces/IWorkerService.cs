using Domain.Dtos;

namespace TesteDS.Blazor.Services.Interfaces
{
    public interface IWorkerService
    {
        Task<List<WorkerDto>> GetAll();
    }
}
