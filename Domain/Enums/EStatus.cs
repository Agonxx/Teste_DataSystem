using System.ComponentModel;

namespace TesteDS.Domain.Enums
{
    public enum EStatus
    {
        [Description("Pendente")]
        Pending = 1,

        [Description("Em Progresso")]
        InProgress = 2,

        [Description("Concluída")]
        Completed = 3
    }
}
