using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

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
        
        // 
        // Entradas:
        // Salidas:
        // Resticciones:
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
        // 
        // Entradas:
        // Salidas:
        // Resticciones:
        public Plato crear_Plato(int precio, int cantidadCalorias, int vecesSolicitada, int tiempoEstimado, 
            string[] listaFeedback, string[] listaIngredientes, string nombre, string tipo)
        {
            return new Plato(precio, cantidadCalorias, vecesSolicitada, tiempoEstimado, 
                listaFeedback, listaIngredientes, nombre, tipo);
            
        }
        // Funcionalidad menu
        
        // 
        // Entradas:
        // Salidas:
        // Resticciones:
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
        
        // 
        // Entradas:
        // Salidas:
        // Resticciones:
        public void agregar_Plato(Plato plato)
        {
            Console.WriteLine("Se agrega plato " + plato.nombre);
            Menu.agregar_plato_menu(plato);
        }
        // 
        // Entradas:
        // Salidas:
        // Resticciones:
        public void agregar_Usuario(Usuario usuario)
        {
            lista_Usuarios.Add(usuario);
        }
        // 
        // Entradas:
        // Salidas:
        // Resticciones:
        public void agregar_Chef(Chef chef)
        {
            lista_Chefs.Add(chef);
        }
        // 
        // Entradas:
        // Salidas:
        // Resticciones:
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
        // 
        // Entradas:
        // Salidas:
        // Resticciones:
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
        
        

    }
}