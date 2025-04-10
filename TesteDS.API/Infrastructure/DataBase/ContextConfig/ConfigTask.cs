using Domain.Constants;
using Domain.Enums;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TesteDS.API.Infrastructure.DataBase.ContextConfig
{
    public class ConfigTask : IEntityTypeConfiguration<TaskItem>
    {
        public void Configure(EntityTypeBuilder<TaskItem> builder)
        {
            builder.HasOne<Worker>()
               .WithMany()
               .HasForeignKey(h => h.WorkerId)
               .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(new[]
             {
                new TaskItem { Id = 1,  WorkerId = 1, Title = SeedConstants.Title01, Description = SeedConstants.Desc01, Status = EStatus.Pending,     CreateAt = DateTime.Now.AddMinutes(-384), UpdateAt = DateTime.Now.AddMinutes(-384), FinishedAt = null},
                new TaskItem { Id = 2,  WorkerId = 2, Title = SeedConstants.Title02, Description = SeedConstants.Desc02, Status = EStatus.Pending,     CreateAt = DateTime.Now.AddMinutes(-984), UpdateAt = DateTime.Now.AddMinutes(-384), FinishedAt = null},
                new TaskItem { Id = 3,  WorkerId = 3, Title = SeedConstants.Title03, Description = SeedConstants.Desc03, Status = EStatus.InProgress,  CreateAt = DateTime.Now.AddMinutes(-484), UpdateAt = DateTime.Now.AddMinutes(-384), FinishedAt = null},
                new TaskItem { Id = 4,  WorkerId = 4, Title = SeedConstants.Title04, Description = SeedConstants.Desc04, Status = EStatus.Pending,     CreateAt = DateTime.Now.AddMinutes(-584), UpdateAt = DateTime.Now.AddMinutes(-384), FinishedAt = null},
                new TaskItem { Id = 5,  WorkerId = 5, Title = SeedConstants.Title05, Description = SeedConstants.Desc05, Status = EStatus.InProgress,  CreateAt = DateTime.Now.AddMinutes(-514), UpdateAt = DateTime.Now.AddMinutes(-384), FinishedAt = null},
                new TaskItem { Id = 6,  WorkerId = 3, Title = SeedConstants.Title06, Description = SeedConstants.Desc06, Status = EStatus.InProgress,  CreateAt = DateTime.Now.AddMinutes(-554), UpdateAt = DateTime.Now.AddMinutes(-384), FinishedAt = null},
                new TaskItem { Id = 7,  WorkerId = 4, Title = SeedConstants.Title07, Description = SeedConstants.Desc07, Status = EStatus.Pending,     CreateAt = DateTime.Now.AddMinutes(-284), UpdateAt = DateTime.Now.AddMinutes(-384), FinishedAt = null},
                new TaskItem { Id = 8,  WorkerId = 6, Title = SeedConstants.Title08, Description = SeedConstants.Desc08, Status = EStatus.InProgress,  CreateAt = DateTime.Now.AddMinutes(-084), UpdateAt = DateTime.Now.AddMinutes(-384), FinishedAt = null},
                new TaskItem { Id = 9,  WorkerId = 7, Title = SeedConstants.Title09, Description = SeedConstants.Desc09, Status = EStatus.Pending,     CreateAt = DateTime.Now.AddMinutes(-784), UpdateAt = DateTime.Now.AddMinutes(-384), FinishedAt = null},
                new TaskItem { Id = 10, WorkerId = 8, Title = SeedConstants.Title10, Description = SeedConstants.Desc10, Status = EStatus.Pending,     CreateAt = DateTime.Now.AddMinutes(-384), UpdateAt = DateTime.Now.AddMinutes(-384), FinishedAt = null},
                                                                                                                                                                                                 
                new TaskItem { Id = 11,  WorkerId = 1, Title = SeedConstants.Title11, Description = SeedConstants.Desc11, Status = EStatus.Pending,    CreateAt = DateTime.Now.AddMinutes(-384), UpdateAt = DateTime.Now.AddMinutes(-384), FinishedAt = null},
                new TaskItem { Id = 12,  WorkerId = 2, Title = SeedConstants.Title12, Description = SeedConstants.Desc12, Status = EStatus.Pending,    CreateAt = DateTime.Now.AddMinutes(-984), UpdateAt = DateTime.Now.AddMinutes(-384), FinishedAt = null},
                new TaskItem { Id = 13,  WorkerId = 3, Title = SeedConstants.Title13, Description = SeedConstants.Desc13, Status = EStatus.InProgress, CreateAt = DateTime.Now.AddMinutes(-484), UpdateAt = DateTime.Now.AddMinutes(-384), FinishedAt = null},
                new TaskItem { Id = 14,  WorkerId = 4, Title = SeedConstants.Title14, Description = SeedConstants.Desc14, Status = EStatus.Pending,    CreateAt = DateTime.Now.AddMinutes(-584), UpdateAt = DateTime.Now.AddMinutes(-384), FinishedAt = null},
                new TaskItem { Id = 15,  WorkerId = 5, Title = SeedConstants.Title15, Description = SeedConstants.Desc15, Status = EStatus.InProgress, CreateAt = DateTime.Now.AddMinutes(-514), UpdateAt = DateTime.Now.AddMinutes(-384), FinishedAt = null},
                new TaskItem { Id = 16,  WorkerId = 3, Title = SeedConstants.Title16, Description = SeedConstants.Desc16, Status = EStatus.InProgress, CreateAt = DateTime.Now.AddMinutes(-554), UpdateAt = DateTime.Now.AddMinutes(-384), FinishedAt = null},
                new TaskItem { Id = 17,  WorkerId = 4, Title = SeedConstants.Title17, Description = SeedConstants.Desc17, Status = EStatus.Pending,    CreateAt = DateTime.Now.AddMinutes(-284), UpdateAt = DateTime.Now.AddMinutes(-384), FinishedAt = null},
                new TaskItem { Id = 18,  WorkerId = 6, Title = SeedConstants.Title18, Description = SeedConstants.Desc18, Status = EStatus.InProgress, CreateAt = DateTime.Now.AddMinutes(-084), UpdateAt = DateTime.Now.AddMinutes(-384), FinishedAt = null},
                new TaskItem { Id = 19,  WorkerId = 7, Title = SeedConstants.Title19, Description = SeedConstants.Desc19, Status = EStatus.Pending,    CreateAt = DateTime.Now.AddMinutes(-784), UpdateAt = DateTime.Now.AddMinutes(-384), FinishedAt = null},
                new TaskItem { Id = 20,  WorkerId = 8, Title = SeedConstants.Title20, Description = SeedConstants.Desc20, Status = EStatus.InProgress, CreateAt = DateTime.Now.AddMinutes(-384), UpdateAt = DateTime.Now.AddMinutes(-384), FinishedAt = null},

            });
        }
    }
}
