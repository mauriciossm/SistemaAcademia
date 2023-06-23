using SistemaAcademia.Models;

namespace SistemaAcademia.Repositorio.Interfaces
{
    public interface IUsuarioRepositorio
    {
        UsuarioModel Adicionar(UsuarioModel usuario);
        UsuarioModel BuscarPorId(int id);
        UsuarioModel BuscarPorLogin(string login);
        UsuarioModel BuscarSenha(string senha);

        bool VerifiqueRegistro(UsuarioModel usuario);
        bool VerifiqueLogin(LoginModel login);

    }
}
