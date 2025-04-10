using Domain.Enums;

namespace Domain.Dtos
{
    public class WorkerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public EPosition Position { get; set; } = EPosition.Developer;
    }
}
