using System.ComponentModel.DataAnnotations;
using TesteDS.Domain.Enums;

namespace TesteDS.Domain.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public int WorkerId { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
        public string Description { get; set; }
        public EStatus Status { get; set; } = EStatus.Pending;
        public DateTime CreateAt { get; set; } = DateTime.Now;
        public DateTime UpdateAt { get; set; } = DateTime.Now;
        public DateTime? FinishedAt { get; set; } = null;
    }

    public class TaskItemRoutesApi
    {
        public const string Create = nameof(Create);
        public const string GetById = nameof(GetById);
        public const string GetAll = nameof(GetAll);
        public const string Update = nameof(Update);
        public const string UpdateStatus = nameof(UpdateStatus);
        public const string DeleteById = nameof(DeleteById);
    }
}
