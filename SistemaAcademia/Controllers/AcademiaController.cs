using Microsoft.AspNetCore.Mvc;

namespace SistemaAcademia.Controllers
{
    public class AcademiaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
