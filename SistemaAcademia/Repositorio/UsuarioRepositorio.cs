using SistemaAcademia.Data;
using SistemaAcademia.Models;
using SistemaAcademia.Repositorio.Interfaces;

namespace SistemaAcademia.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly BancoContext _bancoContext;

        public UsuarioRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public UsuarioModel Adicionar(UsuarioModel usuario)
        {
            _bancoContext.Add(usuario);
            _bancoContext.SaveChanges();
            return usuario;
        }

        public UsuarioModel BuscarPorId(int id)
        {
           return _bancoContext.Usuarios.FirstOrDefault(x=> x.Id== id);    
        }

        public UsuarioModel BuscarPorLogin(string login)
        {
            return _bancoContext.Usuarios.FirstOrDefault(x => x.Login == login);
        }

        public UsuarioModel BuscarSenha(string senha)
        {
            return _bancoContext.Usuarios.FirstOrDefault(x => x.Senha == senha);
        }

        public bool VerifiqueLogin(LoginModel login)
        {
            return login.Login != null && login.Senha != null;
        }



        public bool VerifiqueRegistro(UsuarioModel usuario)
        {
            return usuario.Nome != null &&
                   usuario.CPFCNPJ != null &&
                   usuario.DataNascimento != null &&
                   usuario.Email != null &&
                   usuario.Celular != null &&
                   usuario.Login != null &&
                   usuario.Perfil != null &&
                   usuario.Senha != null;
        }
    }
}
