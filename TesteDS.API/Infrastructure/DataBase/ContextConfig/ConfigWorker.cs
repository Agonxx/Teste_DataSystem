using Domain.Enums;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TesteDS.API.Infrastructure.DataBase.ContextConfig
{
    public class ConfigWorker : IEntityTypeConfiguration<Worker>
    {
        public void Configure(EntityTypeBuilder<Worker> builder)
        {
            builder.HasData(new[]
             {
                new Worker {
                    Id = 1,
                    Name = "Rafael Santos",
                    Position = EPosition.Developer,
                },
                new Worker {
                    Id = 2,
                    Name = "Fernanda Costa",
                    Position = EPosition.Manager,
                },
                new Worker {
                    Id = 3,
                    Name = "Lucas Almeida",
                    Position = EPosition.Analyst,
                },
                new Worker {
                    Id = 4,
                    Name = "Juliana Martins",
                    Position = EPosition.Developer,
                },
                new Worker {
                    Id = 5,
                    Name = "Bruno Ferreira",
                    Position = EPosition.Analyst,
                },
                new Worker {
                    Id = 6,
                    Name = "Camila Oliveira",
                    Position = EPosition.Developer,
                },
                new Worker {
                    Id = 7,
                    Name = "Diego Rocha",
                    Position = EPosition.Analyst,
                },
                new Worker {
                    Id = 8,
                    Name = "Isabela Lima",
                    Position = EPosition.Developer,
                },
                new Worker {
                    Id = 9,
                    Name = "Thiago Moreira",
                    Position = EPosition.Analyst,
                },
                new Worker {
                    Id = 10,
                    Name = "Larissa Ribeiro",
                    Position = EPosition.Developer,
                }
             });
        }
    }
}
