using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Categoria
    {
        private string nombre;
        private string descripcion;

        public string Nombre
        { 
            get { return nombre;}
        }
        public string Descripcion
        { 
            get { return descripcion;}
        }

        public Categoria() { }
        public Categoria(string nombre, string descripcion) 
        { 
            this.nombre = nombre;
            this.descripcion = descripcion;
        }
        public override string ToString()
        {
            return nombre;
        }
        public static bool ValidarCategoria(string nombre, string descripcion)
        {
            return nombre.Trim() != "" && descripcion.Trim() != "";         
        }
        public override bool Equals(object obj)
        {
            Categoria unaC = obj as Categoria;
            return unaC != null && nombre == unaC.Nombre;
        }
    }
}
