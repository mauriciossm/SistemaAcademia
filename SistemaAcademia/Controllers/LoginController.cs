using Microsoft.AspNetCore.Mvc;
using SistemaAcademia.Models;
using SistemaAcademia.Repositorio.Interfaces;

namespace SistemaAcademia.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public LoginController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(RegistroModel registroModel)
        {
            UsuarioModel usuario = registroModel.Cadastro;

            if (_usuarioRepositorio.VerifiqueRegistro(usuario))
            {



                _usuarioRepositorio.Adicionar(usuario);


                return RedirectToAction("Index");
            }
            return View("Index", registroModel);
        }


        [HttpPost]
        public IActionResult Entrar(RegistroModel registroModel)
        {
            LoginModel loginModel = registroModel.Entrada;
            if (_usuarioRepositorio.VerifiqueLogin(loginModel))
            {

                UsuarioModel usuario = _usuarioRepositorio.BuscarPorLogin(loginModel.Login);
                if(usuario.SenhaValida(loginModel.Senha))
                return RedirectToAction("Index", "Home");
            }
            return View("Index", registroModel);
        }
    }
}
