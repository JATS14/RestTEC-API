namespace RestTEC.DB
{
    // Clase menu, es la clase que contiene todos los Platos 
    // La clase con el menu, esta dentro del administrador
    public class Menu
    {
        //Atributos
        public Plato[] Lista_Platos;
        
        //Constructor, getters y setters
        public Menu(Plato[] listaPlatos)
        {
            Lista_Platos = listaPlatos;
        }
        public Plato[] ListaPlatos
        {
            get => Lista_Platos;
            set => Lista_Platos = value;
        }
        
                //Funcionalidad Menu
        
        // 
        // Entradas:
        // Salidas:
        // Resticciones:
        public void agregar_plato_menu(Plato plato)
        {
            
        }
        // 
        // Entradas:
        // Salidas:
        // Resticciones:
        public void eliminar_Plato_Menu(Plato plato)
        {
            
        }
    }
}