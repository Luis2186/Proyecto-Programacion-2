using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Dominio
{
    public class Usuario 
    {
        private int idUsuario;
        private string nombre="";
        private string apellido="";
        private string email="" ;
        private DateTime fechaNacimiento;
        private string nombreUsuario = "";
        private string contraseña = "";
        private string rol = "";
        static int ultId = 0;

        public int IdUsuario
        { 
            get { return idUsuario;}
        }
        public string Nombre
        { 
            get { return nombre;}
        }
        public string Apellido
        { 
            get { return apellido;}
        }
        public string Email
        {
            get { return email;}
        }
        public DateTime FechaNacimiento
        { 
            get { return fechaNacimiento;}
        }
        public string NombreUsuario
        {
            get { return nombreUsuario; }
        }
        public string Contraseña
        {
            get { return contraseña; }
        }
        public string Rol
        {
            get { return rol; }
        }

        public Usuario() { }
        public Usuario(string nombreUsuario, string contraseña) // Constructor usuario sin identificacion
        {
            this.nombreUsuario = nombreUsuario;
            this.contraseña = contraseña;
            this.rol = "SinIdentificar";
        }
        public Usuario(string nombre, string apellido, string email, DateTime fechaNacimiento,string nombreUsuario, string contraseña,string rol)
        {
            ultId++;
            this.idUsuario = ultId;
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.fechaNacimiento = fechaNacimiento;
            this.nombreUsuario = nombreUsuario;
            this.contraseña = contraseña;
            this.rol = rol;
        }
        public override string ToString()
        {
            string Datos;
                Datos = "ID: " + idUsuario + "\n";
                Datos += "Nombre: " + nombre + "\n";
                Datos += "Apellido: " + apellido + "\n";
                Datos += "E-mail: " + email + "\n";
                Datos += "Fecha de Nacimiento:  " + fechaNacimiento.ToShortDateString() + "\n";           
            return Datos;
        }
        public static bool ValidarUsuario(string nombre, string apellido, string email,string contraseña)
        {
            return nombre?.Trim() != null && apellido?.Trim() != null && ValidarEmail(email) && ValidarRegistro(nombre, apellido, contraseña);      
        }
        public static bool ValidarUsuario(string nombre,string contraseña)
        {
            return nombre?.Trim() != null && ValidarRegistro(nombre, contraseña);
        }
        private static bool ValidarEmail(string email)
        {
                bool esValido;
                try {
                    var DirEmail = new System.Net.Mail.MailAddress(email);
                    esValido = DirEmail.Address == email;
                } catch {
                    esValido = false;
                }
                return esValido;
        }
        private static bool ValidarRegistro(string nombre,string apellido,string contraseña) 
        {
            bool esValido=true;

            if(nombre?.Length <2 || apellido?.Length <2 || contraseña?.Length < 6)
            {
                esValido = false;
            }

            if (!ValidarContraseña(contraseña))
            {
                esValido = false;
            }
            return esValido;
        }
        private static bool ValidarRegistro(string nombre, string contraseña) 
        {
            bool esValido = true;

            if (nombre?.Length < 2 || contraseña.Length < 6)
            {
                esValido = false;
            }

            if (!ValidarContraseña(contraseña))
            {
                esValido = false;
            }
            return esValido;
        }
        private static bool ValidarContraseña(string contraseña) 
        {
            bool esValido = false;
            int mayusculas = 0;
            int minusculas = 0;
            int digitos = 0;

            for (int i = 0; i < contraseña?.Length; i++)
            {
                char letra = contraseña[i];
                if (Char.IsDigit(letra))
                {
                    digitos++;
                }

                if (Char.IsLower(letra))
                {
                    minusculas++;
                }

                if (Char.IsUpper(letra))
                {
                    mayusculas++;
                }
            }

            if (mayusculas >= 1 && minusculas >= 1 && digitos >= 1)
            {
                esValido = true;
            }

            return esValido;
        }
        public void UsuarioCliente(string nombreP, string apellidoP, string emailP, DateTime fechaNacimientoP, string nombreUsuarioP, string contraseñaP) 
        {
            nombre = nombreP;
            apellido = apellidoP;
            email = emailP;
            fechaNacimiento = fechaNacimientoP;
            nombreUsuario = nombreUsuarioP;
            contraseña = contraseñaP;
            rol = "Cliente";
        }//Metodo para modificar un usuario sin identificacion
        public override bool Equals(object obj)
        {
            Usuario unU = obj as Usuario;
            return unU != null && nombreUsuario == unU.NombreUsuario && email == unU.Email;
        }  
    }
}
