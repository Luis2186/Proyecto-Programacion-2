using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Actividad 
    {
        private int idActividad;
        private string nombreActividad="";
        private Categoria categoria=null;
        private DateTime fechaYHora;
        private Lugar lugar=null;
        private string edadMinima="";
        private static decimal precioBase=150;
        private int cantidadMegusta=0;
        private static int ultId=0;
        public int IdActividad
        {
            get { return idActividad;} 
        }
        public string NombreActividad
        {
            get { return nombreActividad;}
        }
        public Categoria Categoria 
        {
            get { return categoria;}
        }
        public DateTime FechaYHora
        {
            get { return fechaYHora;}
        }
        public Lugar Lugar
        {
            get { return lugar;} 
        }
        public string EdadMinima 
        {
            get { return edadMinima;}
        }
        public decimal PrecioBase
        {
            get { return precioBase;}
        }
        public int CantidadMegusta
        {
            get { return cantidadMegusta;}
        }
        public Actividad() { }
        public Actividad(string nombre, Categoria categoria, DateTime fechaYHora, Lugar lugar, string edadMinima,int cantidadMegusta) {
            ultId++;
            this.idActividad = ultId;
            this.nombreActividad = nombre;
            this.categoria = categoria;
            this.fechaYHora = fechaYHora;
            this.lugar = lugar;
            this.edadMinima = edadMinima;    
            this.cantidadMegusta = cantidadMegusta;                  
        }       
     
        public static bool ValidarActividad(string nombre, Categoria categoria, Lugar lugar, string edadMinima, int cantidadMegusta)
        {
            return nombre.Trim() != "" && categoria != null && lugar != null && edadMinima !="" && precioBase > 0 && cantidadMegusta >= 0;               
        }
        public static bool ValidarEdad(string edad)
        {
            return edad.ToLower() == "p" || edad.ToLower() == "c13" || edad.ToLower() == "c16" || edad.ToLower() == "c18";
        }

        public decimal CalcularPrecioFinalActividad() //Metodo Polimorfico
        {
            return lugar.FijarTarifa(precioBase);
        }
        public int MeGustaActividad()
        {
            return cantidadMegusta++;
        }
        public override string ToString()
        {
            string Datos;
            Datos = "Identificador de Actividad: " + idActividad + "\n";
            Datos += "Nombre de la activdad: " + nombreActividad + "\n";
            Datos += "Categoria: " + categoria + "\n";
            Datos += "Fecha y Hora: " + fechaYHora + "\n";
            Datos += "Edad Minima: " + edadMinima + "\n";
            Datos += "Cantidad de Megusta: " + cantidadMegusta + "\n";
            Datos += lugar;
            return Datos;
        }
        public override bool Equals(object obj)
        {
            Actividad unaA = obj as Actividad;
            return unaA != null && idActividad == unaA.IdActividad;
        }
    }
}
