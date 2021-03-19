namespace RestTEC.DB
{
    public class Plato
    {
        public int precio;
        public int cantidadCalorias;
        public int vecesSolicitada;
        public int tiempoEstimado;
        public string[] listaFeedback;
        public string[] listaIngredientes;
        public string nombre;
        public string tipo;

        public Plato(int precio, int cantidadCalorias, int vecesSolicitada, int tiempoEstimado, 
            string[] listaFeedback, string[] listaIngredientes, string nombre, string tipo)
        {
            this.precio = precio;
            this.cantidadCalorias = cantidadCalorias;
            this.vecesSolicitada = vecesSolicitada;
            this.tiempoEstimado = tiempoEstimado;
            this.listaFeedback = listaFeedback;
            this.listaIngredientes = listaIngredientes;
            this.nombre = nombre;
            this.tipo = tipo;
        }

        public int Precio
        {
            get => precio;
            set => precio = value;
        }

        public int CantidadCalorias
        {
            get => cantidadCalorias;
            set => cantidadCalorias = value;
        }

        public int VecesSolicitada
        {
            get => vecesSolicitada;
            set => vecesSolicitada = value;
        }

        public int TiempoEstimado
        {
            get => tiempoEstimado;
            set => tiempoEstimado = value;
        }

        public string[] ListaFeedback
        {
            get => listaFeedback;
            set => listaFeedback = value;
        }

        public string[] ListaIngredientes
        {
            get => listaIngredientes;
            set => listaIngredientes = value;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public string Tipo
        {
            get => tipo;
            set => tipo = value;
        }
    }
}