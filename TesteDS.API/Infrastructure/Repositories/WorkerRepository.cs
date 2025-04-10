using Microsoft.EntityFrameworkCore;
using TesteDS.API.Infrastructure.DataBase;
using TesteDS.Domain.Dtos;

namespace TesteDS.API.Infrastructure.Repositories
{
    public class WorkerRepository
    {
        public readonly DBTesteDSContext _db;

        public WorkerRepository(DBTesteDSContext db)
        {
            _db = db;
        }

        public async Task<List<WorkerDto>> GetAll()
        {
            var obj = await (from worker in _db.Workers
                             select new WorkerDto
                             {
                                 Id = worker.Id,
                                 Name = worker.Name,
                                 Position = worker.Position
                             }).OrderBy(w => w.Name).ToListAsync();
            return obj;
        }

    }
}
