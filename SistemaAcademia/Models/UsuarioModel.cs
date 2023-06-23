using SistemaAcademia.Enums;
using System.ComponentModel.DataAnnotations;

namespace SistemaAcademia.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome do usuário")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "Digite o CPF ou CNPJ do usuário")]
        [RegularExpression(@"^[0-9-/.]+$", ErrorMessage = "Use apenas números")]
        public string CPFCNPJ { get; set; }

        [Required(ErrorMessage = "Digite o e-mail do usuário")]
        [EmailAddress(ErrorMessage = "O e-mail informado não é valido")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Digite o celular do usuário")]
        [Phone(ErrorMessage = "Informe um número válido")]
        public string Celular { get; set; }
        
        [Required(ErrorMessage = "Digite o login do usuário")]
        [RegularExpression(@"^[a-zA-Z0-9_.]+$", ErrorMessage = "Utilize apenas caracteres a-z, 0-1, '.' e '_' ")]
        public string Login { get; set; }
        
        [Required(ErrorMessage = "Digite o tipo de perfil do usuário")]
        public PerfilEnum? Perfil { get; set; }
        
        [Required(ErrorMessage = "Digite a senha do usuário")]
        public string Senha { get; set; }
        
        [Required(ErrorMessage = "Informe a data de nascimento do usuário")]
        [DisplayFormat(DataFormatString = "mm/dd/yyyy")]
        public DateTime DataNascimento { get; set; }

        public bool SenhaValida(string senha)
        {
            if (Senha == senha)
            {
                return true;
            }
            return false;
        }
    }
}
