using Microsoft.EntityFrameworkCore;
using TesteDS.API.Infrastructure.DataBase;
using TesteDS.Domain.Dtos;
using TesteDS.Domain.Enums;
using TesteDS.Domain.Models;
using TesteDS.Domain.Utils;

namespace TesteDS.API.Infrastructure.Repositories
{
    public class TaskItemRepository
    {
        public readonly DBTesteDSContext _db;

        public TaskItemRepository(DBTesteDSContext db)
        {
            _db = db;
        }

        public async Task<bool> Create(TaskItemDto taskItemObj)
        {
            TaskItem newObj = new()
            {
                Id = 0,
                WorkerId = taskItemObj.WorderId,
                Title = taskItemObj.Title,
                Description = taskItemObj.Description,
                Status = taskItemObj.Status,
                CreateAt = DateTime.Now,
                UpdateAt = DateTime.Now,
                FinishedAt = taskItemObj.FinishedAt
            };

            await _db.AddAsync(newObj);
            var ret = _db.SaveChanges();

            return ret > 0;
        }

        public async Task<TaskItemDto> GetById(int taskId)
        {
            var obj = await (from tasks in _db.Tasks
                             join worker in _db.Workers on tasks.WorkerId equals worker.Id
                             where tasks.Id == taskId
                             select new TaskItemDto
                             {
                                 Id = tasks.Id,
                                 WorderId = tasks.WorkerId,
                                 WorderName = worker.Name,
                                 Title = tasks.Title,
                                 Description = tasks.Description,
                                 Status = tasks.Status,
                                 CreateAt = tasks.CreateAt,
                                 UpdateAt = tasks.UpdateAt,
                                 FinishedAt = tasks.FinishedAt
                             }).FirstOrDefaultAsync();

            if (obj is null)
                throw new CustomException("Tarefa não encontrada");

            return obj;
        }

        public async Task<List<TaskItemDto>> GetAll()
        {
            var obj = await (from tasks in _db.Tasks
                             join worker in _db.Workers on tasks.WorkerId equals worker.Id
                             select new TaskItemDto
                             {
                                 Id = tasks.Id,
                                 WorderId = tasks.WorkerId,
                                 WorderName = worker.Name,
                                 Title = tasks.Title,
                                 Status = tasks.Status,
                                 CreateAt = tasks.CreateAt,
                                 UpdateAt = tasks.UpdateAt,
                             }).OrderByDescending(w => w.UpdateAt).ToListAsync();

            return obj;
        }

        public async Task<bool> Update(TaskItemDto taskItemObj)
        {
            TaskItem newObj = new()
            {
                Id = taskItemObj.Id,
                WorkerId = taskItemObj.WorderId,
                Title = taskItemObj.Title,
                Description = taskItemObj.Description,
                Status = taskItemObj.FinishedAt != null ? Domain.Enums.EStatus.Completed : taskItemObj.Status,
                CreateAt = taskItemObj.CreateAt,
                UpdateAt = DateTime.Now,
                FinishedAt = taskItemObj.FinishedAt
            };

            _db.Update(newObj);
            var ret = _db.SaveChanges();

            return ret > 0;
        }

        public async Task<bool> UpdateStatus(TaskItemDto taskItemObj)
        {
            var removes = await _db.Tasks
                                .Where(w => w.Id == taskItemObj.Id)
                                .ExecuteUpdateAsync(spc =>
                                spc.SetProperty(x => x.Status, EStatus.Completed)
                                    .SetProperty(x => x.UpdateAt, DateTime.Now)
                                    .SetProperty(x => x.FinishedAt, taskItemObj.Status == EStatus.Completed ? DateTime.Now : null));

            if (removes == 0)
                throw new CustomException("A tarefa não foi atualizada");

            return true;
        }

        public async Task<bool> DeleteById(int taskId)
        {
            var removes = await _db.Tasks
                                .Where(w => w.Id == taskId)
                                .ExecuteDeleteAsync();
            if (removes == 0)
                throw new CustomException("A tarefa não foi encontrada/excluída");

            return true;
        }
    }
}
