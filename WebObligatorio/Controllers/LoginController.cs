using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Http;
using Dominio;

namespace WebObligatorio.Controllers
{
    public class LoginController : Controller
    {
        Sistema s = Sistema.GetInstancia();
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string nombreDeUsuario,string password)
        {
            Usuario unU = s.Login(nombreDeUsuario, password);

            if (unU != null)
            {
                HttpContext.Session.SetString("LogNombre", unU.NombreUsuario);
                HttpContext.Session.SetString("LogRol", unU.Rol);
            } else
            {
                ViewBag.Error = "Las credenciales son incorrectas o se encuentran vacias.";
                ViewBag.Error1 = "¡Ingrese los datos correctamente y vuelva a intentarlo!";
            }

                if(HttpContext.Session.GetString("LogRol") == "SinIdentificar")
                { 
                    return RedirectToAction("Bienvenida", "Usuario");
                } else if (HttpContext.Session.GetString("LogRol") == "Cliente")
                {
                    return RedirectToAction("Bienvenida", "Usuario");
                }
                else if(HttpContext.Session.GetString("LogRol") == "Operador")
                {
                    return RedirectToAction("Bienvenida", "Usuario");
                } else
                {
                    return View();
                }            
        }
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login","Login");
        }
    }
}
