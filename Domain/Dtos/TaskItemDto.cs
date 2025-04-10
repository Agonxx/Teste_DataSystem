using Domain.Enums;
using FluentValidation;

namespace Domain.Dtos
{
    public class TaskItemDto
    {
        public int Id { get; set; }
        public int WorderId { get; set; }
        public string WorderName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public EStatus Status { get; set; } = EStatus.Pending;
        public DateTime CreateAt { get; set; } = DateTime.Now;
        public DateTime UpdateAt { get; set; } = DateTime.Now;
        public DateTime? FinishedAt { get; set; }
    }

    public class TaskItemDtoValidator : AbstractValidator<TaskItemDto>
    {
        public TaskItemDtoValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Título é obrigatório")
                .MaximumLength(100).WithMessage("Máximo 100 caracteres");

            RuleFor(x => x.WorderId)
                .GreaterThan(0).WithMessage("Necessário vincular um colaborador a tarefa");

            RuleFor(x => x.WorderId)
                .GreaterThan(0).WithMessage("Necessário vincular um colaborador a tarefa");

            RuleFor(x => x.FinishedAt)
                .GreaterThan(x => x.CreateAt).WithMessage("A data de conclusão deve ser superior à data de criação.")
                .When(x => x.FinishedAt.HasValue);
        }
    }
}
