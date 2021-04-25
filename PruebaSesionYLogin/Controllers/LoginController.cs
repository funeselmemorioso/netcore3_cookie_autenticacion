using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaSesionYLogin.Models;
using PruebaSesionYLogin.Sessions;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PruebaSesionYLogin.Controllers
{ 
    public class LoginController : Controller
    {
        ISessionUser _sessionUser;

        public LoginController(ISessionUser sessionUser)
        {
            _sessionUser = sessionUser;
        }
        
        public async Task<IActionResult> Index()
        {
            return View();                        
        }   
        
        public IActionResult UsuarioNoRegistrado()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {           
            await HttpContext.SignOutAsync();
            //_sessionUser.DestroySession(HttpContext);
            return Json("ok");
        }

        [HttpPost]
        public async Task<IActionResult> Loguearse(User user)
        {
            if (user.Username == "admin" && user.Password == "admin")
            {
                user.Rol = "general";
                user.FirstName = "Juan";
                user.LastName = "Perez";
               


                var claims = new List<Claim>
                {                      
                    new Claim(ClaimTypes.NameIdentifier, user.Username),
                    new Claim(ClaimTypes.Name, user.FirstName),
                    new Claim(ClaimTypes.Surname, user.LastName),
                    new Claim(ClaimTypes.Role, user.Rol)
                };
                var claimsIdentity = new ClaimsIdentity(claims, "Login");

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

                return Json("ok");
            }
            return Json("bad");         
        }
    }
}

