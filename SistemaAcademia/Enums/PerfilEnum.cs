using System.ComponentModel;

namespace SistemaAcademia.Enums
{
    public enum PerfilEnum : int
    {
        [Description("Proprietário")]
        Admin = 1,
        [Description("Aluno")]
        Padrao = 2
    }
}
