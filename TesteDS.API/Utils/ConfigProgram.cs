using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.OpenApi.Models;
using TesteDS.API.Application;
using TesteDS.API.Infrastructure.DataBase;
using TesteDS.API.Infrastructure.Repositories;

namespace TesteDS.API.Utils
{
    public static class ConfigProgram
    {

        public static IServiceCollection SetupServices(this IServiceCollection services)
        {
            services.AddScoped<TaskItemService>();
            services.AddScoped<WorkerService>();

            services.AddScoped<TaskItemRepository>();
            services.AddScoped<WorkerRepository>();
            
            return services;
        }

        public static IServiceCollection SetupDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DBTesteDS");

            services.AddDbContext<DBTesteDSContext>(options =>
                options.UseSqlServer(connectionString)
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
                .ConfigureWarnings(warnings =>
                    warnings.Ignore(RelationalEventId.PendingModelChangesWarning)));

            return services;
        }

        public static IServiceCollection SetupCORS(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAllOrigins", policy =>
                {
                    policy.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader();
                });
            });

            return services;
        }

        public static IServiceCollection SetupSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Tarefas API",
                    Version = "v1",
                    Description = "Exemplo de API protegida com JWT"
                });
            });

            return services;
        }
    }
}
