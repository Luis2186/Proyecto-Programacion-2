using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Dominio
{
    public class ComparadorClienteApellido : IComparer<Usuario> 
    {
        public int Compare(Usuario x, Usuario y)
        {
            if(x.Apellido == y.Apellido) { 
                return x.Nombre.CompareTo(y.Nombre);
            } else
            {
                return x.Apellido.CompareTo(y.Apellido);
            }
        }
    }
}
