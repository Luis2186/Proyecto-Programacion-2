using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Compra
    {       
        private int idCompra;
        private Actividad actividadComprada = null;
        private int cantidadDeEntradas=0;
        private Usuario idUsuarioCompra=null;
        private DateTime fechaYHoraCompra;
        private bool estado= true;
        private decimal precioFinal =0;
        static int ultId = 0;

        public int IdCompra
        { 
            get { return idCompra;}
        }
        public Actividad ActividadComprada
        { 
            get { return actividadComprada;}
        }
        public int CantidadDeEntradas
        { 
            get { return cantidadDeEntradas;}
        }
        public Usuario IdUsuarioCompra
        { 
            get { return idUsuarioCompra;}
        }
        public DateTime FechaYHoraCompra
        { 
            get { return fechaYHoraCompra;}
        }
        public bool Estado
        { 
            get { return estado;}
        }
        public decimal PrecioFinal
        { 
            get { return precioFinal;} 
        }

        public Compra() { }
        public Compra(int cantidadDeEntradas, Actividad actividadComprada, Usuario idUsuarioCompra, DateTime fechaYHoraCompra)
        {
            ultId++;
            this.idCompra = ultId;
            this.actividadComprada = actividadComprada;
            this.cantidadDeEntradas = cantidadDeEntradas;
            this.idUsuarioCompra = idUsuarioCompra;
            this.fechaYHoraCompra = fechaYHoraCompra;
            this.precioFinal = CalcularPrecioFinal();
        }
        public static bool ValidarCompra(int cantidadDeEntradas, Actividad actividadComprada, Usuario idUsuarioCompra)
        {
            return cantidadDeEntradas > 0 && actividadComprada != null && idUsuarioCompra != null;
        } 
        public override string ToString()
        {
            string Datos;
                Datos = "ID: " + idCompra + "\n";
                Datos += "Actividad: " + actividadComprada.NombreActividad + "\n";
                Datos += "cantidadDeEntradas: " + cantidadDeEntradas + "\n";
                Datos += "Usuario ID: " + idUsuarioCompra.IdUsuario + "\n";
                Datos += "Fecha de Compra:  " + fechaYHoraCompra.ToShortDateString() + "\n";
                Datos += "Estado De Compra: " + EstadoCompra(estado) + "\n";
                Datos += "Precio Final: " + precioFinal + "\n";
            return Datos;
        }
        private string EstadoCompra(bool Estado)
        {
            return Estado == true ? "Activa" : "Cancelada";
        }
        public bool CancelarCompra()
        {
            return estado = false; 
        }     
        private decimal CalcularPrecioFinal() // Metodo Polimorfico
        {
            decimal precioFinal = actividadComprada.CalcularPrecioFinalActividad() * cantidadDeEntradas;
                if (cantidadDeEntradas > 5)
                {
                    precioFinal *= 0.95m;
                }
                return precioFinal;
        }
        public override bool Equals(object obj)
        {
            Compra unaC = obj as Compra;
            return unaC != null && idCompra == unaC.IdCompra;
        }
    }
}
