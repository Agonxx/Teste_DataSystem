using Domain.Enums;

namespace Domain.Models
{
    public class Worker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public EPosition Position { get; set; } = EPosition.Developer;
    }

    public class WorkerRoutesApi
    {
        public const string GetAll = nameof(GetAll);
    }
}
