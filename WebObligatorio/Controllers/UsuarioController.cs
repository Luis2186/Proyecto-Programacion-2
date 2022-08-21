using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Dominio;

namespace WebObligatorio.Controllers
{
    public class UsuarioController : Controller
    {
        Sistema s = Sistema.GetInstancia();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AltaUsuario()
        {
            if (HttpContext.Session.GetString("LogRol") == "SinIdentificar")
            {
                return View(new Usuario());
            } else
            {
               return RedirectToAction("Login", "Login");
            }
        }
        [HttpPost]
        public IActionResult AltaUsuario(string nombre, string apellido, string email, DateTime fechaNacimiento,string nombreUsuario, string contraseña)
        {
            string nombreUsuarioLog = HttpContext.Session.GetString("LogNombre");
            Usuario usuarioEditado = s.BuscarUsuario(nombreUsuarioLog);
            bool editado = false;  
                 editado = s.EditarUsuario(usuarioEditado, nombre, apellido,email,fechaNacimiento, nombreUsuario, contraseña); 

            if (editado == true)
                {          
                ViewBag.ResultadoOk = "¡Usted se registro correctamente como Cliente!";
                }
                else
                {
                ViewBag.nombre = nombre;
                ViewBag.apellido = apellido;
                ViewBag.email = email;
                ViewBag.fechaNacimiento = fechaNacimiento.ToString("yyyy-MM-dd");
                ViewBag.nombreUsuario = nombreUsuario;
                ViewBag.ResultadoError = "¡No se ah podido registrar, ingrese los datos correctamente!";
                }           
            return View();
        }
        public IActionResult AltaUsuarioSinIdentificar()
        {      
            return View();     
        }
        [HttpPost]
        public IActionResult AltaUsuarioSinIdentificar(string nombreUsuario, string contraseña)
        {    
            Usuario usuarioEditado = s.AgregarUsuarioSinIdentificar(nombreUsuario, contraseña);
            
                if (usuarioEditado != null)
                {
                    ViewBag.ResultadoOk = "¡Usted se registro correctamente!";
                }
                else
                {        
                    ViewBag.nombreUsuario = nombreUsuario;
                    ViewBag.ResultadoError = "¡No se ah podido registrar, ingrese los datos correctamente!. La contraseña debe tener una minuscula, una mayuscula y un digito como minimo.";
                }
            return View();
        }
        public IActionResult ListaUsuario()
        {
            if (HttpContext.Session.GetString("LogRol") == "Operador")
            {
                ViewBag.ListaUsuarios = s.ClientesOrdenados();
                return View();
            } else
            {
                return RedirectToAction("Login", "Login");
            }
        }
        public IActionResult Bienvenida()
        {
            

            if (HttpContext.Session.GetString("LogRol") == "SinIdentificar" || HttpContext.Session.GetString("LogRol") == "Cliente" ||
                HttpContext.Session.GetString("LogRol") == "Operador")
            {
                string nombreUsuarioLog = HttpContext.Session.GetString("LogNombre");
                Usuario User = s.BuscarUsuario(nombreUsuarioLog);
                return View(User);
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }

    }
}
