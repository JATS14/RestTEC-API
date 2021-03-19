namespace RestTEC.DB
{
    public class Menu
    {
        public Plato[] Lista_Platos;
        public Menu(Plato[] listaPlatos)
        {
            Lista_Platos = listaPlatos;
        }
        public Plato[] ListaPlatos
        {
            get => Lista_Platos;
            set => Lista_Platos = value;
        }
    }
}