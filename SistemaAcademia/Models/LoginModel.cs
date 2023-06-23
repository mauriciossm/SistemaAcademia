using System.ComponentModel.DataAnnotations;

namespace SistemaAcademia.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage= "Informe o login do usuário")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Informe a senha do usuário")]
        public string Senha { get; set; }

    }
}
