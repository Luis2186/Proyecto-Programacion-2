using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Dominio;

namespace WebObligatorio.Controllers
{
    public class ActividadController : Controller
    {
        Sistema s = Sistema.GetInstancia();
        public IActionResult Index()
        {
            return View();
        }
           
        public IActionResult ListarActividades() 
        {
            if (HttpContext.Session.GetString("LogRol") == "SinIdentificar")
            {
                ViewBag.ListaAct = s.Actividades;
                return View();
            } else
            {
                return RedirectToAction("Login", "Login");
            }
        }
    
        public IActionResult SegunCatFecha()
        {
            if (HttpContext.Session.GetString("LogRol") == "Operador")
            {
                ViewBag.Categorias = s.Categorias;
                return View();
            } else
            {
                return RedirectToAction("Login", "Login");
            }
        }
        [HttpPost]
        public IActionResult SegunCatFecha(string nombreCat,DateTime desde,DateTime hasta)
        {
            ViewBag.Categorias = s.Categorias;
            ViewBag.unaA = s.ActividadSegunCategoriaYFechas(nombreCat, desde, hasta);     
            if (ViewBag.unaA.Count == 0)
            {
                ViewBag.Respuesta = "No se encontro una actividad en el rango de fechas dados";
            }
            return View();
        }
        public IActionResult SegunLugar()
        {
            if (HttpContext.Session.GetString("LogRol") == "Operador")
            {
                ViewBag.unL = s.Lugares;
                return View();
            } else
            {
                return RedirectToAction("Login", "Login");
            }
        }
        [HttpPost]
        public IActionResult SegunLugar(string nombreLugar)
        {
            ViewBag.unL = s.Lugares;
            ViewBag.unaA = s.ActividadSegunLugar(nombreLugar);       
            if (ViewBag.unaA.Count == 0)
            {
                ViewBag.Respuesta = "No se encontro una actividad en el Lugar mencionado";
            }
            return View();
        }

        public IActionResult ListActCompra() 
        {
            if (HttpContext.Session.GetString("LogRol") == "Cliente")
            {
                ViewBag.ListaAct = s.Actividades;
                return View();
            } else
            {
                return RedirectToAction("Login", "Login");
            }   
        }
        public IActionResult ListActMeGusta() 
        {
            if (HttpContext.Session.GetString("LogRol") == "Cliente")
            {
                ViewBag.ListaActividades = s.Actividades;
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }
        public IActionResult MeGustaActividad(string nombreActividad) 
        {
            if (HttpContext.Session.GetString("LogRol") == "Cliente")
            {
                Actividad unaA = s.BuscarActividad(nombreActividad);
                unaA.MeGustaActividad();
                return RedirectToAction("ListActMeGusta", "Actividad");
            }else
            {
                return RedirectToAction("Login", "Login");
            }
        }    
    }
}
