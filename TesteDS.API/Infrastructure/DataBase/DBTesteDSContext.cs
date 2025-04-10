using Domain.Models;
using Microsoft.EntityFrameworkCore;
using TesteDS.API.Infrastructure.DataBase.ContextConfig;

namespace TesteDS.API.Infrastructure.DataBase
{
    public class DBTesteDSContext : DbContext
    {
        public DBTesteDSContext(DbContextOptions<DBTesteDSContext> options) : base(options)
        {
        }
        public DbSet<TaskItem> Tasks { get; set; }
        public DbSet<Worker> Workers{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ConfigTask());
            modelBuilder.ApplyConfiguration(new ConfigWorker());
        }
    }
}
