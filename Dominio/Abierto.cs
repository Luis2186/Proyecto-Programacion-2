using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Abierto : Lugar
    {
        private static decimal precioButaca=0;        
        private decimal costoMantenimiento=0;
        public decimal PrecioButaca
        { 
            get { return precioButaca;}
        }
        public Abierto() { }
        public Abierto(string nombreLugar, int dimensiones, decimal costoMantenimiento) : base(nombreLugar, dimensiones)
        {
            this.idLugar = ultId;    
            this.costoMantenimiento = costoMantenimiento;
        }
        public override decimal FijarTarifa(decimal precioBase) //Metodo Polimorfico
        {
            decimal recargo = 1;

                if (this.dimensiones > 1)
                {
                recargo += 0.10m;
                }
  
            return recargo * precioBase;
        }
        public decimal FijarPreciosButacas(decimal PrecioButaca) {
            return precioButaca = PrecioButaca;
        }
        public override string ToString()
        {
            string Datos;
            Datos = base.ToString();
            Datos += "Tipo de Lugar: Abierto \n";
            Datos += "Precio de la Butaca : " + precioButaca + "\n";
            return Datos;
        }
        public static bool ValidarLugarAbierto(string nombreLugar, int dimensiones, decimal costoMantenimiento)
        {
            return nombreLugar.Trim() != "" && dimensiones > 0 && costoMantenimiento > 0;
        }
        public override bool Equals(object obj)
        {
            Abierto unLA = obj as Abierto;
            return unLA != null && idLugar == unLA.IdLugar;
        }
    }
}
