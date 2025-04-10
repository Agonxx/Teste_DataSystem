using System.ComponentModel;

namespace Domain.Enums
{
    public enum EPosition
    {
        [Description("Gerente")]
        Manager = 1,

        [Description("Analista")]
        Analyst = 2,

        [Description("Desenvolvedor")]
        Developer = 3
    }
}
