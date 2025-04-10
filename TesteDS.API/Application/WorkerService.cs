using TesteDS.API.Infrastructure.Repositories;
using TesteDS.Domain.Dtos;

namespace TesteDS.API.Application
{
    public class WorkerService
    {
        private readonly WorkerRepository _workerRepository;

        public WorkerService(WorkerRepository workerRepository)
        {
            _workerRepository = workerRepository;
        }

        public async Task<List<WorkerDto>> GetAll()
        {
            var obj = await _workerRepository.GetAll();
            return obj;
        }
    }
}
