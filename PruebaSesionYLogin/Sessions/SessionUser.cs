using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using PruebaSesionYLogin.Models;
using System;
using System.Linq;

namespace PruebaSesionYLogin.Sessions
{
    public class SessionUser : ISessionUser
    {       
        //public void SetUsuarioSession(HttpContext context, object value)
        //{
        //    if (string.IsNullOrEmpty(context.Session.GetString("usuario")))
        //    {
        //        var str = JsonConvert.SerializeObject(value);
        //        context.Session.SetString("usuario", str);
        //    }           
        //}

        //public User GetUsuarioSession(HttpContext context)
        //{
        //    if (!string.IsNullOrEmpty(context.Session.GetString("usuario")))
        //    {
        //        String stringOBJ = context.Session.GetString("usuario");
        //        var obj = JsonConvert.DeserializeObject<User>(stringOBJ);
        //        return (User)obj;
        //    }
        //    return null; 
        //}

        //public void DestroySession(HttpContext context)
        //{
        //    if (!string.IsNullOrEmpty(context.Session.GetString("usuario")))
        //    {
        //        context.Session.Remove("usuario");
        //    }
        //}

        public String GetNombreUsuarioClaim(HttpContext context)
        {
            return context.User.Claims.FirstOrDefault(x => x.Type == System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
        }

        public String GetRolUsuarioClaim(HttpContext context)
        {
            return context.User.Claims.FirstOrDefault(x => x.Type == System.Security.Claims.ClaimTypes.Role)?.Value;
        }
        
    }
}
