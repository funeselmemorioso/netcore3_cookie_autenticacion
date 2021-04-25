using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PruebaSesionYLogin.Controllers
{
    [Authorize]
    public class PersonasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
