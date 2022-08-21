using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Cerrado : Lugar
    {
        private bool accesibilidadTotal;
        private decimal valorMantenimientoEspacio=0;
        static int aforoMaximo;

        public bool AccesibilidadTotal
        { 
            get { return accesibilidadTotal;}
        }
        public decimal ValorMantenimientoEspacio
        { 
            get { return valorMantenimientoEspacio;}
        }
        public static int AforoMaximo
        { 
            get { return aforoMaximo;} 
        }

        public Cerrado() { }
        public Cerrado(string nombreLugar, int dimensiones, decimal valorMantenimientoEspacio,bool accesibilidadTotal) : base(nombreLugar, dimensiones)
        {
            this.idLugar = ultId;              
            this.accesibilidadTotal = accesibilidadTotal;
            this.valorMantenimientoEspacio = valorMantenimientoEspacio;         
        }
        public override decimal FijarTarifa(decimal precioBase) //Metodo Polimorfico
        {
            decimal precioTotal = precioBase;
                if (aforoMaximo < 50)
                {
                precioTotal *= 1.30m;
                }

                if (aforoMaximo >= 50 && aforoMaximo <= 70)
                {
                precioTotal *= 1.15m;
                }
            return precioTotal;
        }
        public override string ToString()
        {
            string Datos;
                Datos =  base.ToString();
                Datos += "Tipo de Lugar: Cerrado \n";
                Datos += "Valor de Mantenimiento : " + valorMantenimientoEspacio + "\n"; 
            return Datos;
        }
        public bool CambiarAforo(int valorAforo, int porcentajeMaximo= int.MaxValue) 
        {
            bool estadoDeIngreso = false;
                if (valorAforo <= porcentajeMaximo) {
                    aforoMaximo = valorAforo;
                    estadoDeIngreso = true;
                }
            return estadoDeIngreso;
        }
        public int mostrarAforoMaximo()
        {
            return aforoMaximo;
        }
        public static bool ValidarLugarCerrado(string nombreLugar, int dimensiones, decimal valorMantenimientoEspacio)
        {
            return nombreLugar.Trim() != "" && dimensiones > 0 && valorMantenimientoEspacio > 0;
        }
        public override bool Equals(object obj)
        {
            Cerrado unLC = obj as Cerrado;
            return unLC != null && idLugar == unLC.IdLugar;
        }
    }
}
