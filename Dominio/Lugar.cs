using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public abstract class Lugar 
    {
        protected int idLugar;
        protected string nombreLugar="";
        protected int dimensiones = 0;
        protected static int ultId = 0;
       
        public int IdLugar
        { 
            get { return idLugar;}
        }
        public string NombreLugar
        { 
            get { return nombreLugar;}
        }
        public int Dimensiones
        { 
            get { return dimensiones;}
        }

        public Lugar() { }
        public Lugar(string nombreLugar, int dimensiones) {
            ultId++;
            this.idLugar = ultId;
            this.nombreLugar = nombreLugar;
            this.dimensiones = dimensiones;
        }
        public abstract decimal FijarTarifa(decimal precioBase); //Metodo Polimorfico
        public override string ToString()
        {
            string Datos;
                Datos = "Lugar: " + nombreLugar + "\n";  
                Datos += "Dimensiones: " + dimensiones + " km2" + "\n";
            return Datos;
        }
       
    }
}
