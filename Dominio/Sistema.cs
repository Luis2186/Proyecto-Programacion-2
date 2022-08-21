using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Sistema
    {
        private Sistema() { }
        private static Sistema instancia = null;
        public static Sistema GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new Sistema();
                instancia.CargarValores();
                instancia.CargarUsuarios();
                instancia.CargarLugares();
                instancia.CargarCategorias();
                instancia.CargarActividades();
                instancia.CargarCompras();
            }
            return instancia;
        }

        private List<Usuario> usuarios = new List<Usuario>();
        private List<Actividad> actividades = new List<Actividad>();
        private List<Lugar> lugares = new List<Lugar>();
        private List<Categoria> categorias = new List<Categoria>();
        private List<Compra> compras = new List<Compra>();
        public List<Usuario> Usuarios
        { 
            get { return usuarios; } 
        }
        public List<Actividad> Actividades
        { 
            get { return actividades;}
        }
        public List<Lugar> Lugares
        { 
            get { return lugares;}
        }
        public List<Categoria> Categorias 
        { 
            get { return categorias;}
        }
        public List<Compra> Compras 
        { 
            get { return compras;}
        }
        private void CargarUsuarios()
        {   
            //Usuarios Sin Identificacion
            AgregarUsuarioSinIdentificar("Lucho", "Lucho1234");
            AgregarUsuarioSinIdentificar("Gaston", "Gaston1234");
            AgregarUsuarioSinIdentificar("Sol", "Sol1234");
            //Usuarios Cliente
            AgregarUsuario("CFlorencia", "Pereira", "jose6.p@hotmail.com", new DateTime(1994, 06, 02), "Josefina6", "Josefina1234", "Cliente"); //Testeo Orden Lista
            AgregarUsuario("BAgustina", "Pereira", "jose7.p@hotmail.com", new DateTime(1994, 06, 02), "Josefina7", "Josefina1234", "Cliente");  //Testeo Orden Lista
            AgregarUsuario("APedro", "Pereira", "jose8.p@hotmail.com", new DateTime(1994, 06, 02), "Josefina8", "Josefina1234", "Cliente");     //Testeo Orden Lista      
            AgregarUsuario("Josefina", "Pereira", "jose.p@hotmail.com", new DateTime(1994, 06, 02), "Josefina", "Josefina1234", "Cliente");
            AgregarUsuario("Alvaro", "Fernandez", "alvaro.fer25@hotmail.com", new DateTime(1986, 10, 25), "Alvaro", "Alvaro1234", "Cliente");
            AgregarUsuario("Ana", "Mendez", "anamendez1995@hotmail.com", new DateTime(1995, 03, 12), "Ana", "Ana1234", "Cliente");
            AgregarUsuario("Federico", "Gonzales", "fede_12@hotmail.com", new DateTime(1990, 04, 16), "Federico", "Federico1234", "Cliente");
            //Usuario Operador
            AgregarUsuario("Santiago", "Unty", "SantiagoUn@hotmail.com", new DateTime(1990, 04, 16), "Santiago", "Santiago1234", "Operador");
            AgregarUsuario("Nicolas", "Soler", "NicoSoler@hotmail.com", new DateTime(1990, 04, 16), "Nicolas", "Nicolas1234", "Operador");
            AgregarUsuario("Lucia", "Arrospide", "LuchiArrospide@hotmail.com", new DateTime(1990, 04, 16), "Lucia", "Lucia1234", "Operador");
            //Errores de Usuario
            AgregarUsuario(" ", "Ente", "luca.s@hotmail.com", new DateTime(1994, 04, 03),"Lucas", "Lucas1234", "SinIdentificar");   // Error Nombre Vacio 
            AgregarUsuario("cris", "  ", "crito@hotmail.com", new DateTime(1990, 10, 24), "Cris", "Cris1234", "SinIdentificar");   // Error Apellido Vacio   
            AgregarUsuario("lolo", "pons", "crito hotmail.com", new DateTime(1896, 11, 14), "lolo", "lolo1234", "SinIdentificar");   // Error Email Incorrecto
            AgregarUsuario("Josefina12", "Pereira12", "jose.p@hotmail.com", new DateTime(1994, 06, 02), "Josefina244", "Josefina1234", "SinIdentificar");   // Error Email repetido
            AgregarUsuario("Josefina1", "Pereira1", "jose.p123@hotmail.com", new DateTime(1994, 06, 02),"Josefina", "Josefina1234", "SinIdentificar"); // Error Nombre de Usuario repetido
            AgregarUsuario("lolo1", "pons", "crito1@hotmail.com", new DateTime(1896, 11, 14), "lolo1", "lolo1234", "SinIdentificar");   // Error Contraseña sin mayuscula 
            AgregarUsuario("lolo2", "pons", "crito2@hotmail.com", new DateTime(1896, 11, 14), "lolo2", "LOLO1234", "SinIdentificar");   // Error Contraseña sin minuscula 
            AgregarUsuario("lolo3", "pons", "crito3@hotmail.com", new DateTime(1896, 11, 14), "lolo3", "Lololololo", "SinIdentificar");   // Error Contraseña sin digito 
            AgregarUsuario("lolo4", "pons", "crito4@hotmail.com", new DateTime(1896, 11, 14), "lolo4", "Lol12", "SinIdentificar");   // Error Contraseña 5 caracteres 
            AgregarUsuario("lolo5", "p", "crito5@hotmail.com", new DateTime(1896, 11, 14), "lolo5", "Lolo1234", "SinIdentificar");   // Error Apellido 1 caracter 
            AgregarUsuario("l", "pons", "crito4@hotmail.com", new DateTime(1896, 11, 14), "lolo4", "lolo1234", "SinIdentificar");   // Error Nombre 1 caracter
        }
        private void CargarCategorias() 
        {           
            AgregarCategoria("Cine", "Las mejores peliculas");
            AgregarCategoria("Teatro", "Obras imperdibles");
            AgregarCategoria("Concierto", "Shows imperdibles");
            AgregarCategoria("Feria Gastronomica", "Comidas Gourmet de primer nivel");
            AgregarCategoria("Feria Tecnologica", "Las inovaciones mas asombrosas");
            //Errores Categoria
            AgregarCategoria("sky", "   "); //Error descripcion vacia
            AgregarCategoria("   ", "Asombroso");// Error nombre vacio;
        }
        private void CargarLugares() 
        {
            // Lugares Abiertos
            AgregarLugarAbierto("Prado", 20, 11000);
            AgregarLugarAbierto("Parque Rodo", 30, 5000);
            AgregarLugarAbierto("Parque Rivera", 40, 12000);
            AgregarLugarAbierto("Parque Roosvelt", 60, 9000);
            AgregarLugarAbierto("Plaza Virgilio", 28, 15000);
            AgregarLugarAbierto("Plaza Cagancha", 1 , 15000);
            AgregarLugarAbierto("Plaza Conaprole", 1, 15000);
            // Errores Lugar Abierto
            AgregarLugarAbierto("  ", 28, 15000); // Error Nombre vacio
            AgregarLugarAbierto("Plaza Virgilio", 0, 9000); //Error dimension 0
            AgregarLugarAbierto("Plaza Virgilio", 0, 0); //Error precioMantenimiento 0
            //Lugares Cerrados
            AgregarLugarCerrado("World Trade Center", 45, 5000, true);
            AgregarLugarCerrado("Movie Center", 24, 3500, true);
            AgregarLugarCerrado("Casino Carrasco", 30, 7000, false);
            AgregarLugarCerrado("Sodre", 50, 5500, false);
            AgregarLugarCerrado("Casino Conrad", 45, 10000, true);
            // Errores Lugar Cerrado
            AgregarLugarCerrado("   ", 45, 10000, true);    // Error Nombre vacio
            AgregarLugarCerrado("Casino Conrad", 0, 10000, true);  // Error dimension 0
            AgregarLugarCerrado("Casino Conrad", 45, 0, true);  // Error Valor mantenimiento 0
        }
        private void CargarActividades()
        {
            AgregarActividad("Plaza Conaprole", BuscarCategoria("Feria Tecnologica"), DateTime.Now , BuscarLugar("Plaza Conaprole"), "P", 12); // Actividad con Lugar Abierto 1km
            AgregarActividad("Plaza Cagancha", BuscarCategoria("Feria Tecnologica"), new DateTime(2021, 05, 04, 12, 25, 00), BuscarLugar("Plaza Cagancha"), "P", 12);   // Actividad con Lugar Abierto 1km
            AgregarActividad("Prado", BuscarCategoria("Concierto"), new DateTime(2021, 09, 06, 17, 25, 00), BuscarLugar("Prado"), "P", 50);
            AgregarActividad("Prado1", BuscarCategoria("Concierto"), new DateTime(2021, 09, 06, 17, 25, 00), BuscarLugar("Prado"), "P", 50);
            AgregarActividad("Prado2", BuscarCategoria("Concierto"), new DateTime(2021, 09, 06, 17, 25, 00), BuscarLugar("Prado"), "P", 50);
            AgregarActividad("Parque Rodo", BuscarCategoria("Feria Gastronomica"), new DateTime(2021, 05, 15, 16, 30, 15), BuscarLugar("Parque Rodo"), "C13", 26);
            AgregarActividad("Parque Rodo1", BuscarCategoria("Feria Gastronomica"), new DateTime(2021, 05, 15, 16, 30, 15), BuscarLugar("Parque Rodo"), "C13", 26);
            AgregarActividad("Parque Rivera", BuscarCategoria("Concierto"), new DateTime(2021, 09, 06, 13, 14, 15), BuscarLugar("Parque Rivera"), "C16", 35);
            AgregarActividad("Parque Roosvelt", BuscarCategoria("Feria Gastronomica"), new DateTime(2021, 07, 06, 14, 27, 03), BuscarLugar("Parque Roosvelt"), "P", 58);
            AgregarActividad("Plaza Virgilio", BuscarCategoria("Feria Gastronomica"), new DateTime(2021, 11, 25, 17, 25, 36), BuscarLugar("Plaza Virgilio"), "C18", 165);
            AgregarActividad("World Trade Center", BuscarCategoria("Feria Tecnologica"), new DateTime(2021, 09, 06, 20, 39, 54), BuscarLugar("World Trade Center"), "C16", 45);
            AgregarActividad("Movie Center", BuscarCategoria("Cine"), new DateTime(2021, 09, 06, 11, 25, 17), BuscarLugar("Movie Center"), "P", 83);
            AgregarActividad("Casino Carrasco", BuscarCategoria("Teatro"), new DateTime(2021, 09, 06, 21, 45, 36), BuscarLugar("Casino Carrasco"), "C18", 36);
            AgregarActividad("Sodre", BuscarCategoria("Concierto"), new DateTime(2021, 09, 06, 18, 56, 14), BuscarLugar("Sodre"), "P", 300);
            AgregarActividad("Casino Conrad", BuscarCategoria("Feria Gastronomica"), new DateTime(2021, 01, 02, 12, 25, 22), BuscarLugar("Casino Conrad"), "C18", 235);
            //Errores Actividades
            AgregarActividad("Prado", BuscarCategoria("Concierto"), new DateTime(2021, 09, 06), BuscarLugar("Prado"), "P", 50); // Error Actividad Repetida
            AgregarActividad("", BuscarCategoria("Concierto"), new DateTime(2021, 09, 06), BuscarLugar("Prado"), "P", 51); //Error Actividad Nombre Vacio
            AgregarActividad("Prado", BuscarCategoria(" "), new DateTime(2021, 09, 06), BuscarLugar("Prado"), "P", 52);//Error Actividad Categoria null
            AgregarActividad("Prado1", BuscarCategoria("Concierto"), new DateTime(2021, 09, 06), BuscarLugar(" "), "P", 53);//Error Actividad Lugar null
            AgregarActividad("Prado2", BuscarCategoria("Concierto"), new DateTime(2021, 09, 06), BuscarLugar("Prado"), "As", 54);//Error Actividad edadMinima Incorrecta
            AgregarActividad("Prado3", BuscarCategoria("Concierto"), new DateTime(2021, 09, 06), BuscarLugar("Prado"), " ", 55);//Error Actividad edadMinima Vacia        
        }
        private void CargarCompras()
        {
            AgregarCompra(2, BuscarActividad("Prado"), BuscarUsuario("Josefina", "jose.p@hotmail.com"),new DateTime(2021, 09, 06,16,30,00));
            AgregarCompra(5, BuscarActividad("Parque Rodo"), BuscarUsuario("Alvaro", "alvaro.fer25@hotmail.com"), new DateTime(2021, 03, 05,17,25,00));
            AgregarCompra(3, BuscarActividad("Parque Rivera"), BuscarUsuario("Ana", "anamendez1995@hotmail.com"), new DateTime(2021, 09, 24,08,14,25));
            AgregarCompra(1, BuscarActividad("Parque Roosvelt"), BuscarUsuario("Federico", "fede_12@hotmail.com"), new DateTime(2021, 02, 19,20,36,22));
            AgregarCompra(4, BuscarActividad("World Trade Center"), BuscarUsuario("Alvaro", "alvaro.fer25@hotmail.com"), new DateTime(2021, 01, 04,21,45,00));
            AgregarCompra(6, BuscarActividad("Movie Center"), BuscarUsuario("Josefina", "jose.p@hotmail.com"), new DateTime(2021, 09, 05,13,25,36));

            AgregarCompra(7, BuscarActividad("Casino Conrad"), BuscarUsuario("Ana", "anamendez1995@hotmail.com"), new DateTime(2021, 07, 30, 23 ,00, 00));
            AgregarCompra(7, BuscarActividad("Casino Conrad"), BuscarUsuario("Ana", "anamendez1995@hotmail.com"), new DateTime(2021, 10, 30, 23, 56, 22));
            AgregarCompra(7, BuscarActividad("Casino Conrad"), BuscarUsuario("Ana", "anamendez1995@hotmail.com"), new DateTime(2021, 10, 31, 23, 00, 22));
            //Errores Compra
            AgregarCompra(2, BuscarActividad("Prado12"), BuscarUsuario("Josefina124", "jose.p@hotmail.com"), new DateTime(2021, 09, 06)); //Error Actividad vacia o incorrecta
            AgregarCompra(2, BuscarActividad("Prado"), BuscarUsuario("JosefinaASD", "jose.p@hotmail.com"), new DateTime(2021, 09, 06)); //Error Usuario vacio o incorrecto
            AgregarCompra(0, BuscarActividad("Prado"), BuscarUsuario("Josefina123", "jose.p@hotmail.com"), new DateTime(2021, 09, 06)); //Error 0 cantidad de entradas 
        }
        private void CargarValores()
        {
            CambiarValorButaca(150);
            CambiarAforoMaximo(49);
        }
        public void CambiarValorButaca(int ValorButaca) 
        {
            Abierto CambiarPrecio = new Abierto(); 
            CambiarPrecio.FijarPreciosButacas(ValorButaca);
        }
        public bool CambiarAforoMaximo(int valorAforo, int PorcentajeMaximo = int.MaxValue) 
        {
           Cerrado CambiarAforo = new Cerrado();
           return CambiarAforo.CambiarAforo(valorAforo, PorcentajeMaximo);
        }  
        public Usuario AgregarUsuario(string nombre, string apellido, string email, DateTime fechaNacimiento,string nombreUsuario, string contraseña,string rol)
        {
            Usuario User = null;        
                if (Usuario.ValidarUsuario(nombre, apellido, email, contraseña) && BuscarUsuario(nombreUsuario, email) == null)
                { 
                    User= new Usuario(nombre, apellido, email, fechaNacimiento, nombreUsuario, contraseña, rol);
                     usuarios.Add(User);     
                }          
            return User;
        }
        public Usuario AgregarUsuarioSinIdentificar(string nombreUsuario, string contraseña) 
        {
            Usuario User = null;
            if (Usuario.ValidarUsuario(nombreUsuario, contraseña) && BuscarUsuario(nombreUsuario) == null)
            {
                User = new Usuario(nombreUsuario, contraseña);
                usuarios.Add(User);
            }
            return User;
        }
        public bool AgregarLugarAbierto(string nombreLugar, int dimensiones,decimal costoMantenimiento) 
        {
            bool SeAgrego = false;
                if (Abierto.ValidarLugarAbierto(nombreLugar, dimensiones, costoMantenimiento) && BuscarLugar(nombreLugar)==null ) { 
                    Abierto Abierto = new Abierto(nombreLugar, dimensiones, costoMantenimiento);
                    lugares.Add(Abierto);
                    SeAgrego = true;
                }
            return SeAgrego;
        }
        public bool AgregarLugarCerrado(string nombreLugar, int dimensiones, decimal valorMantenimientoEspacio, bool accesibilidadTotal) 
        {
            bool SeAgrego = false;
                if (Cerrado.ValidarLugarCerrado(nombreLugar, dimensiones, valorMantenimientoEspacio) && BuscarLugar(nombreLugar)==null) { 
                    Cerrado Cerrado = new Cerrado(nombreLugar, dimensiones, valorMantenimientoEspacio, accesibilidadTotal);
                    lugares.Add(Cerrado);
                    SeAgrego = true;
                }
            return SeAgrego;
        }
        public bool AgregarCompra(int cantidadDeEntradas, Actividad actividadComprada, Usuario idUsuarioCompra, DateTime fechaYHoraCompra) 
        {
            bool SeAgrego = false;
                if (Compra.ValidarCompra(cantidadDeEntradas, actividadComprada, idUsuarioCompra) ) { 
                    Compra nuevaCompra = new Compra(cantidadDeEntradas, actividadComprada, idUsuarioCompra,fechaYHoraCompra);
                    compras.Add(nuevaCompra);
                    SeAgrego = true;
                }
            return SeAgrego;
        }
        public bool AgregarCategoria(string nombre, string descripcion) 
        {
            bool SeAgrego = false;
                if (Categoria.ValidarCategoria(nombre, descripcion) && BuscarCategoria(nombre)==null) { 
                    Categoria Cat = new Categoria(nombre, descripcion);
                    categorias.Add(Cat);
                    SeAgrego = true;
                }
            return SeAgrego;
        }
        public bool AgregarActividad(string nombre, Categoria categoria, DateTime fechaYHora, Lugar lugar, string edadMinima, int cantidadMegusta)
        {
            bool SeAgrego = false;
            if (Actividad.ValidarActividad(nombre, categoria, lugar, edadMinima, cantidadMegusta) && Actividad.ValidarEdad(edadMinima) && BuscarActividad(nombre)==null) {
                Actividad NuevaActividad = new Actividad(nombre, categoria, fechaYHora, lugar, edadMinima, cantidadMegusta);
                actividades.Add(NuevaActividad);
                SeAgrego = true;
            }
            return SeAgrego;
        }
        public Categoria BuscarCategoria(string Nombre)
        {
            Categoria nuevaCat = null; 
            int i = 0;           
                while (nuevaCat==null && i < categorias.Count)
                {
                    if (categorias[i].Nombre == Nombre) {
                        nuevaCat = categorias[i];
                    }              
                i++;
                }        
            return nuevaCat;   
        }
        public Lugar BuscarLugar(string Nombre)
        {
            Lugar nuevoLugar = null;
            int i = 0; 
                while (nuevoLugar==null && i < lugares.Count) {
                    if (lugares[i].NombreLugar == Nombre) {
                        nuevoLugar = lugares[i];    
                    }
                i++;
                }
            return nuevoLugar;
        }      
        public Actividad BuscarActividad(string Nombre)
        {
            Actividad nuevaActividad = null;
            int i = 0;            
                while (nuevaActividad==null && i < actividades.Count) {
                    if (actividades[i].NombreActividad == Nombre) {
                        nuevaActividad = actividades[i];  
                    }
                    i++;
                }
            return nuevaActividad;
        }
        public Usuario BuscarUsuario(string NombreUsuario,string Email) 
        {
            Usuario nuevoUsuario = null;
            int i = 0;
                while (nuevoUsuario == null && i < usuarios.Count) {
                    if (usuarios[i].NombreUsuario == NombreUsuario || usuarios[i].Email == Email) {
                        nuevoUsuario = usuarios[i];
                    }
                    i++;
                }
            return nuevoUsuario;
        }
        public Usuario BuscarUsuario(string NombreUsuario)
        {
            Usuario nuevoUsuario = null;
            int i = 0;
            while (nuevoUsuario == null && i < usuarios.Count)
            {
                if (usuarios[i].NombreUsuario == NombreUsuario)
                {
                    nuevoUsuario = usuarios[i];
                }
                i++;
            }
            return nuevoUsuario;
        }
        public Compra BuscarCompra(int id,string nombreUsuario)
        {
            Compra nuevaCompra = null;
            int i = 0;
                while (nuevaCompra == null && i < compras.Count) {
                    if (compras[i].IdCompra == id && compras[i].Estado==true && compras[i].IdUsuarioCompra.NombreUsuario == nombreUsuario) {
                        nuevaCompra = compras[i];
                    }
                    i++;
                }
            return nuevaCompra;
        }
        public bool CancelarCompra(int IdCompra)  
        {
            bool realizado = false;
            foreach(Compra unaC in compras){
                var horas = (DateTime.Now - unaC.ActividadComprada.FechaYHora).TotalHours;

                if(unaC.IdCompra== IdCompra && unaC.Estado==true && horas > 24) {
                    unaC.CancelarCompra();
                    realizado = true;
                }
            }
            return realizado;
        }      
        public List<Actividad> ActividadSegunCategoriaYFechas(string Categoria, DateTime Desde, DateTime Hasta)
        {
            List<Actividad> ListaAuxiliar = new List<Actividad>();       
                foreach (Actividad act in Actividades) {
                    if (act.FechaYHora >= Desde && act.FechaYHora <= Hasta && act.Categoria.Nombre == Categoria) {
                        ListaAuxiliar.Add(act);
                    }
                }            
            return ListaAuxiliar;
        }
        public List<Actividad> ActividadSegunLugar(string Lugar)    
        {
            List<Actividad> ListaAuxiliar = new List<Actividad>();
            foreach (Actividad act in Actividades)
            {
                if (act.Lugar.NombreLugar == Lugar)
                {
                    ListaAuxiliar.Add(act);
                }
            }
            return ListaAuxiliar;
        }
        public List<Compra> ComprasMayorValor()    
        {
            List<Compra> auxCompra = new List<Compra>();
            decimal mayorValor = decimal.MinValue;
            decimal precio = 0m;

            foreach (Compra unaC in Compras)
            {
                precio = unaC.PrecioFinal;

                if (precio > mayorValor)
                {
                    mayorValor = precio;
                    auxCompra.Clear();
                    auxCompra.Add(unaC);
                }
                else if(precio == mayorValor){
                    auxCompra.Add(unaC);
                }
            }
            return auxCompra;
        }
        public List<Compra> CompraEntreFechas(DateTime Desde, DateTime Hasta)  
        {
            List<Compra> auxCompra = new List<Compra>();
            foreach (Compra unaC in Compras)
            {
                if (unaC.FechaYHoraCompra >= Desde && unaC.FechaYHoraCompra <= Hasta && unaC.Estado==true)
                {
                    auxCompra.Add(unaC);
                }
            }
            return auxCompra;
        }
        public decimal MontoTotalCompras(List<Compra> compras)  
        {
            decimal total = 0;

                foreach (Compra unaC in compras)
                {
                    total += unaC.PrecioFinal;
                }
                return total;
        }
        public List<Compra> CompraSegunCliente(string nombreUsuario)   
        {
            List<Compra> auxCompra = new List<Compra>();
            foreach (Compra unaC in Compras)
            {
                if (unaC.IdUsuarioCompra.NombreUsuario == nombreUsuario && unaC.Estado == true)
                {
                    auxCompra.Add(unaC);
                }
            }
            return auxCompra;
        }
        public List<Usuario> ClientesOrdenados()  
        {
            List<Usuario> auxCompra = new List<Usuario>();
                foreach (Usuario unUser in usuarios)
                {
                    if (unUser.Rol == "Cliente")
                    { 
                        auxCompra.Add(unUser);
                    }
                }
            auxCompra.Sort(new ComparadorClienteApellido());
            return auxCompra;
        }   
        public Usuario Login(string nombreUsuario, string password)
        {
            Usuario nuevoUsuario = null;
            int i = 0;
                while (nuevoUsuario == null && i < usuarios.Count)
                {
                    if (usuarios[i].NombreUsuario == nombreUsuario && usuarios[i].Contraseña == password)
                    {
                        nuevoUsuario = usuarios[i];
                    }
                    i++;
                }
            return nuevoUsuario;
        }    
        public bool EditarUsuario(Usuario User,string nombre, string apellido, string Email, DateTime fechaNacimiento, string NombreUsuario, string Contraseña)
        {
            bool correcto = false;
                if (Usuario.ValidarUsuario(nombre, apellido, Email, Contraseña) && User!=null && BuscarUsuario(NombreUsuario, Email) == null)
                {
                    User.UsuarioCliente(nombre, apellido, Email, fechaNacimiento, NombreUsuario, Contraseña);
                    correcto = true;
                }     
            return correcto;
        }
    }
}
