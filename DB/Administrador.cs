using System;
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
        public Pedido[] Lista_Pedidos;
        public Menu menu;
        public Usuario[] lista_Usuarios;
        
        //Constructor, getters y setters
        public Administrador(string correo, string contrasena, Pedido[] listaPedidos, 
                            Menu menu, Usuario[] listaUsuarios)
        
        {
            this.correo = correo;
            this.contrasena = contrasena;
            Lista_Pedidos = listaPedidos;
            this.menu = menu;
            lista_Usuarios = listaUsuarios;
        }

        protected Administrador()
        {
            throw new NotImplementedException();
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

        public Pedido[] ListaPedidos
        {
            get => Lista_Pedidos;
            set => Lista_Pedidos = value;
        }
        
        public Menu Menu
        {
            get => menu;
            set => menu = value;
        }
             // Funcionalidad Platos
        
        // 
        // Entradas:
        // Salidas:
        // Resticciones:
        public void gestionar_Plato()
        {
            
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
        // 
        // Entradas:
        // Salidas:
        // Resticciones:
        public Plato editar_Plato(Plato plato)
        {
            return plato;
        }
        // 
        // Entradas:
        // Salidas:
        // Resticciones:
        public void eliminar_Plato(Plato plato)
        {
            
        }
        
                // Funcionalidad menu
        
        // 
        // Entradas:
        // Salidas:
        // Resticciones:
        public void gestionar_Menu()
        {
            for (int i = 0; i < menu.Lista_Platos.Length;i++)
            {
                Console.WriteLine("--------Plato "+(i+1)+", Tipo: "+ menu.Lista_Platos[i].tipo+"--------");
                Console.WriteLine("Nombre: "+menu.Lista_Platos[i].nombre);
                Console.WriteLine("Calorias: "+menu.Lista_Platos[i].cantidadCalorias);
                Console.WriteLine("Tiempo estimado Preparacion: "+menu.Lista_Platos[i].tiempoEstimado);
                //onsole.WriteLine("Estrellas Promedio: "+menu.Lista_Platos[i].);
                Console.Write("ingredientes: ");
                for (int j = 0; j < (menu.Lista_Platos[i].listaIngredientes.Length - 1); j++)
                {
                    Console.Write(menu.Lista_Platos[i].listaIngredientes[j]+", ");
                }
                Console.Write(menu.Lista_Platos[i].listaIngredientes[(menu.Lista_Platos[i].listaIngredientes.Length - 1)]);
                Console.WriteLine(" ");
                Console.WriteLine("----------------");
            }
        }

    }
}