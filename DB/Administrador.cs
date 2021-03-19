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
        //Constructor, getters y setters
        public Administrador(string correo, string contrasena, Pedido[] listaPedidos, Menu menu)
        {
            this.correo = correo;
            this.contrasena = contrasena;
            Lista_Pedidos = listaPedidos;
            this.menu = menu;
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
        // 
        // Entradas:
        // Salidas:
        // Resticciones:
        
             // Funcionalidad menu
        public void gestionar_Menu()
        {
            
        }
    }
}