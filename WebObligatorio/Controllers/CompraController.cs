using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Dominio;

namespace WebObligatorio.Controllers
{
    public class CompraController : Controller
    {
        Sistema s = Sistema.GetInstancia(); 
        public IActionResult ComprasMayores()
        {
            if (HttpContext.Session.GetString("LogRol") == "Operador")
            {
                ViewBag.unaC = s.ComprasMayorValor(); 
                return View();
            }
            else
            {
                return RedirectToAction("Login","Login");
            }
        }
        public IActionResult ComprasEntreFechas()
        {
            if (HttpContext.Session.GetString("LogRol") == "Operador")
            {
                return View();
            } else
            {
                return RedirectToAction("Login", "Login");
            }
        }
        [HttpPost]
        public IActionResult ComprasEntreFechas(DateTime desde, DateTime hasta)
        {
            ViewBag.unaC = s.CompraEntreFechas(desde, hasta); 
            ViewBag.Total = s.MontoTotalCompras(s.CompraEntreFechas(desde, hasta));
            if(ViewBag.unaC.Count == 0)
            {
                ViewBag.Respuesta = "No se han podido encontrar compras entre el rango de fechas dado";
            }
            return View();
        }
        public IActionResult CompraSegunCliente()
        {
            if (HttpContext.Session.GetString("LogRol") == "Cliente")
            {
                string nombreUserLog = HttpContext.Session.GetString("LogNombre");
                ViewBag.CompraCliente = s.CompraSegunCliente(nombreUserLog); 
                return View();
            }else
            {
                return RedirectToAction("Login", "Login");
            }
        }
        public IActionResult BuscarCompra()
        {
            if (HttpContext.Session.GetString("LogRol") == "Cliente")
            {
                return View();
            } else
            {
                return RedirectToAction("Login", "Login");
            }
        }
        [HttpPost]
        public IActionResult BuscarCompra(int id)
        {
            string nombreUserLog = HttpContext.Session.GetString("LogNombre");
            ViewBag.unaC = s.BuscarCompra(id,nombreUserLog);
            if(ViewBag.unaC == null)
            {
                ViewBag.Resultado= "No se ah podido encontrar ninguna compra con ese numero, ingreselo correctamente y vuelva a intentarlo";
            }
            return View();
        }
        public IActionResult CancelarCompra(int id)
        {
            if (HttpContext.Session.GetString("LogRol") == "Cliente")
            {
                bool cancelarCompra = s.CancelarCompra(id); 
                if (cancelarCompra)
                {
                    ViewBag.ResultadoOk = "La compra se cancelo correctamente";
                }
                else
                {
                    ViewBag.ResultadoError = "La cancelacion solo se puede realizar si esta comprendida dentro del plazo de 24 horas antes de la realizacion de la Actividad." +
                                                    "Plazo maximo exedido, no se ah podido llevar a cabo la cancelacion";
                }
                return View();
            } else
            {
                return RedirectToAction("Login", "Login");
            }
        }
        public IActionResult ComprarActividad()
        {
            if (HttpContext.Session.GetString("LogRol") == "Cliente")
            {
                return View();
            } else
            {
                return RedirectToAction("Login","Login");
            }
        }
        [HttpPost]
        public IActionResult ComprarActividad(string NombreAct,int cantidadEntradas)
        {
            string nombreUserLog = HttpContext.Session.GetString("LogNombre");
            Actividad unaA = s.BuscarActividad(NombreAct);
            Usuario unUser = s.BuscarUsuario(nombreUserLog);  
            bool unaC = s.AgregarCompra(cantidadEntradas, unaA, unUser, DateTime.Now); 
            if (unaC)
            {
                ViewBag.ResultadoOk = "La compra se ah realizado con exito";
            }
            else
            {     
                ViewBag.ResultadoError = "La compra no se ah podido realizar, verifique si ingreso los datos correctamente";
            }
            return View();
        }
        public IActionResult ComprarEntradas()
        {
            if (HttpContext.Session.GetString("LogRol") == "Cliente")
            {
                ViewBag.Act = s.Actividades;
                ViewBag.User = s.Usuarios;
                return View();
            }else {
                return RedirectToAction("Login", "Login");
            }
        }
        [HttpPost]
        public IActionResult ComprarEntradas(string nombreActividad, int cantidadEntradas)
        {
            ViewBag.Act = s.Actividades;
            ViewBag.User = s.Usuarios;
            string nombreUserLog = HttpContext.Session.GetString("LogNombre");
            Actividad unaA = s.BuscarActividad(nombreActividad);
            Usuario unUser = s.BuscarUsuario(nombreUserLog);   
            bool unaC = s.AgregarCompra(cantidadEntradas, unaA, unUser, DateTime.Now); 
            if (unaC)
            {
                ViewBag.ResultadoOk = "La compra se ah realizado con exito";
            }
            else
            {
                ViewBag.ResultadoError = "La compra no se ah podido realizar";
            }
            return View();
        }

    }
}
