using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaSesionYLogin.Controllers
{
    [Authorize]
    public class AutosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
