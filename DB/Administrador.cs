using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text.Json;

namespace RestTEC.DB
{
    // Clase administrador, el la clase encargada de manejar la lista de pedidos y el menu
    // Se puede acceder a la funcionalidad de la clase por medio de una contrasena y un correo
    // y es el encargado de controlar el menu que se le montrara al usuario.
    public class Administrador {   
        //Atributos
        public string correo;
        private string contrasena;
        public IList<Pedido> Lista_Pedidos;
        public IList<Usuario> lista_Usuarios;
        public IList<Chef> lista_Chefs;

        //Constructor, getters y setters
        public Administrador(string correo, string contrasena, IList<Pedido> listaPedidos, 
            IList<Usuario> listaUsuarios, IList<Chef> listaChefs)
        
        {
            this.correo = correo;
            this.contrasena = contrasena;
            Lista_Pedidos = listaPedidos;
            lista_Usuarios = listaUsuarios;
            lista_Chefs = listaChefs;

        }
        
        public string Correo
        {
            get => correo;
            set => correo = value;
        }
        public string Contrasena
        {
            get => contrasena;
            set => contrasena = value;
        }
        
        
             // Funcionalidad Platos
        
        // Funcion encargada de mostrar los pedidos que esten en el sistema
        // Entradas: esta funcion no tiene entradas
        // Salidas: esta funcion no tiene salidas
        // Resticciones: no tiene restricciones
        public void gestionar_Pedidos()
        {
            Console.WriteLine("Se mostraran los Pedidos, cantidad: " + Lista_Pedidos.Count);
            for (int i = 0; i < Lista_Pedidos.Count;i++)
            {
                Console.WriteLine("--------Plato "+(i+1)+", Nombre: "+ Lista_Pedidos[i].plato.nombre+"--------");
                if (Lista_Pedidos[i].chef_Asignado != null)
                {
                    Console.WriteLine("Chef asignado: "+ Lista_Pedidos[i].chef_Asignado.nombre);
                    int calculo_tiempo = Lista_Pedidos[i].plato.tiempoEstimado + Lista_Pedidos[i].chef_Asignado.calcular_tiempo();
                    Console.WriteLine("Tiempo Aproximado: "+ calculo_tiempo);
                }
                else
                {
                    Console.WriteLine("Chef asignado: "+ "No hay chef asignado");
                    Console.WriteLine("Tiempo Aproximado: "+"-" );
                }
                Console.WriteLine("----------------");
            }
        }
        // funicion encargade de crear un plato
        // Entradas: hay que introducir el precio, cantidad de calorias, veces solicitadas, tiempo restimado
        //        lista feedback, lista ingredientes, un nombre y un tipo
        // Salidas: la salida es el plato creado
        // Resticciones: todos los atributos entrantes tienen que ser del tipo asignado previamente
        public Plato crear_Plato(int precio, int cantidadCalorias, int vecesSolicitada, int tiempoEstimado, 
            IList<FeedBack> listaFeedback, IList<string> listaIngredientes, string nombre, string tipo)
        {
            return new Plato(precio, cantidadCalorias, vecesSolicitada, tiempoEstimado, 
                listaFeedback, listaIngredientes, nombre, tipo);
            
        }
        // Funcionalidad menu
        
        // Funcion encargada de mostrar con detalle todos los paltillos que estan en el menu
        // Entradas: esta funcion no tiene entradas
        // Salidas: esta funcion no tiene salidas
        // Resticciones: esta funcion no tiene restricciones
        public void gestionar_Menu()
        {
            Console.WriteLine("Se mostraran los platos, cantidad: " + Menu.ListaPlatos.Count);
            for (int i = 0; i < Menu.ListaPlatos.Count;i++)
            {
                Console.WriteLine("--------Plato "+(i+1)+", Tipo: "+ Menu.ListaPlatos[i].tipo+"--------");
                Console.WriteLine("Nombre: "+Menu.ListaPlatos[i].nombre);
                Console.WriteLine("Calorias: "+Menu.ListaPlatos[i].cantidadCalorias);
                Console.WriteLine("Tiempo estimado Preparacion: "+Menu.ListaPlatos[i].tiempoEstimado);
                //onsole.WriteLine("Estrellas Promedio: "+menu.Lista_Platos[i].);
                Console.Write("ingredientes: ");
                for (int j = 0; j < (Menu.ListaPlatos[i].listaIngredientes.Count - 1); j++)
                {
                    Console.Write(Menu.ListaPlatos[i].listaIngredientes[j]+", ");
                }
                Console.Write(Menu.ListaPlatos[i].listaIngredientes[(Menu.ListaPlatos[i].listaIngredientes.Count - 1)]);
                Console.WriteLine(" ");
                Console.WriteLine("----------------");
            }
        }
        
        // Funcion que agrega un plato al menu
        // Entradas: la entrada es un plato
        // Salidas: No posee salidas
        // Resticciones: la entradad tiene que ser un plato, previamente creado, o con los atributos correctos
        public void agregar_Plato(Plato plato)
        {
            Console.WriteLine("Se agrega plato " + plato.nombre);
            Menu.agregar_plato_menu(plato);
        }
        // Funcion que agrega un usuario nuevo a la lista de usuarios
        // Entradas: La entrada es un usuario nuevo
        // Salidas: esta funcion no posee salidas
        // Resticciones:la entradad tiene que ser un Usuario, previamente creado, o con los atributos correctos
        public void agregar_Usuario(Usuario usuario)
        {
            lista_Usuarios.Add(usuario);
        }
        // Funcion que agrega un Chef nuevo a la lista de Chefs
        // Entradas: La entrada es un usuario Chef
        // Salidas: esta funcion no posee salidas
        // Resticciones:la entradad tiene que ser un Chef, previamente creado, o con los atributos correctos
        public void agregar_Chef(Chef chef)
        {
            lista_Chefs.Add(chef);
        }
        // Funcion que le asigna un pepido a un chef
        // Entradas: la entrada es el nuemero de un chef y el nuemero de un pedido
        // Salidas:esta funcion no posee salidas
        // Resticciones: los nuemeros del chef y el pedido tiene que ser valores existentes
        public void pedido_Chef_obtener(int numero_Chef, int numero_Pedido)
        {
            try
            {
                lista_Chefs[numero_Chef].tomar_Pedido(Lista_Pedidos[numero_Pedido]);
                Lista_Pedidos[numero_Pedido].chef_Asignado = lista_Chefs[numero_Chef];
                Lista_Pedidos[numero_Pedido].tiempo_estimado_finalizacion = 
                    (lista_Chefs[numero_Chef].calcular_tiempo() - Lista_Pedidos[numero_Pedido].tiempo_estimado_finalizacion);
            }
            catch
            {
                Console.WriteLine("El pedido o el Chef no existen");
            }
        }
        // Funcion que le quita un pedido a un chef y lo reasigna a pedidos pendientes
        // Entradas: El numero de un chef y el numero de un pepido
        // Salidas: esta funcion no tiene salidas
        // Resticciones: los nuemeros del chef y el pedido tiene que ser valores existentes
        public void pedido_Chef_Soltar(int numero_Chef, int numero_Pedido)
        {
            try
            {
                Lista_Pedidos.Add(lista_Chefs[numero_Chef].soltar_pedido(numero_Pedido));

                Lista_Pedidos[numero_Pedido].chef_Asignado = null;
                Lista_Pedidos[numero_Pedido].tiempo_estimado_finalizacion = Lista_Pedidos[numero_Pedido].plato.tiempoEstimado ;
            }
            catch
            {
                Console.WriteLine("El pedido o el Chef no existen");
            }
        }
        // Funcion que revisa el ingreso de un Usuario ya registrado
        // Entradas: se le ingresa un correo y una contrasena
        // Salidas: returna un true si el usuario esta en el sistema o un false si no
        // Resticciones: el correo y la contrasena tiene que ser strings
        public bool ingresar_Usuario(String correo, string contrasena)
        {
            for (int i = 0; i < lista_Usuarios.Count; i++)
            {
                if (lista_Usuarios[i].correo.Equals(correo) &&
                    lista_Usuarios[i].Contrasena.Equals(contrasena))
                {
                    return true;
                }
            }

            return false;
        }
        // Funcion que revisa el ingreso de un Chef ya registrado
        // Entradas: se le ingresa un correo y una contrasena
        // Salidas: returna un true si el Chef esta en el sistema o un false si no
        // Resticciones: el correo y la contrasena tiene que ser strings
        public bool ingresar_Chef(String correo, string contrasena)
        {
            for (int i = 0; i < lista_Chefs.Count; i++)
            {
                if (lista_Chefs[i].correo.Equals(correo) &&
                    lista_Chefs[i].Contrasena.Equals(contrasena))
                {
                    return true;
                }
            }
            return false;
        }
        // Funcion que muestra un JSON de todos los usuario registrados en el sistema
        // Entradas: esta funcion no posee entradas
        // Salidas: Las salida es un string con formato JSON
        // Resticciones: esta funcion no tiene restricciones
        public String get_lista_Usuarios_Json()
        {
            string jsonString = JsonSerializer.Serialize(lista_Usuarios);
            return jsonString;
        }
        // Funcion que muestra un JSON de todos los Chefs registrados en el sistema
        // Entradas: esta funcion no posee entradas
        // Salidas: Las salida es un string con formato JSON
        // Resticciones: esta funcion no tiene restricciones
        public String get_lista_Chef_Json()
        {
            string jsonString = JsonSerializer.Serialize(lista_Chefs);
            return jsonString;
        }
        // Funcion que muestra un JSON de todos los pedidos registrados en el sistema
        // Entradas: esta funcion no posee entradas
        // Salidas: Las salida es un string con formato JSON
        // Resticciones: esta funcion no tiene restricciones
        public String get_lista_Pedidos_Json()
        {
            string jsonString = JsonSerializer.Serialize(Lista_Pedidos);
            return jsonString;
        }
        // Funcion que muestra un JSON de todos los Platos registrados en el sistema
        // Entradas: esta funcion no posee entradas
        // Salidas: Las salida es un string con formato JSON
        // Resticciones: esta funcion no tiene restricciones
        public String get_lista_Platos_Json()
        {
            string jsonString = JsonSerializer.Serialize(Menu.Lista_Platos);
            return jsonString;
        }
        
        //-------------TOPS!!!!-------------
        
        
        
        //-------------FeedBack-------------
        // Funcion encargada de asignar un feedback de un cliente si este hace uno
        // Entradas: se ingresa un plato al que se le asignara el feedback, y un feedback
        // Salidas: esta funcion no tiene salidas
        // Resticciones: el plato tiene que ser un plato registrado en el sistema y el feedback
        //               tiene que tener un formato correcto
        public void usuario_feedback(Plato plato, FeedBack feedback)
        {
            Menu.buscar_PLato(plato).agregar_Feedback(feedback);
        }
    }
}