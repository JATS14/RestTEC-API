using System.Collections.Generic;

namespace RestTEC.DB
{
    // Clase plato, clase que contiene la informacion de los platos para el menu
    // Los Platos se pueden crear por los administradores.
    public class Plato
    {
        //Atributos
        public int precio;
        public int cantidadCalorias;
        public int vecesSolicitada;
        public int tiempoEstimado;
        public IList<FeedBack> listaFeedback;
        public IList<string> listaIngredientes;
        public string nombre;
        public string tipo;

        //Constructor, getters y setters
        public Plato(int precio, int cantidadCalorias, int vecesSolicitada, int tiempoEstimado, 
            IList<FeedBack> listaFeedback, IList<string> listaIngredientes, string nombre, string tipo)
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

        public IList<FeedBack> ListaFeedback
        {
            get => listaFeedback;
            set => listaFeedback = value;
        }

        public IList<string> ListaIngredientes
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
    
                //Funcionalidad PLato
        
        // Funcion que cambia el precio del plato por uno nuevo ingresado
        // Entradas: la entrada es un entero 
        // Salidas: esta funcion no tiene salidas
        // Resticciones: la entrada es un entero nuevo distingo de cero y positivo
        public void cambiar_Precio(int precio)
        {
            this.precio = precio;
        }
        // Funcion que asigna un nuevo feedback a esta clase
        // Entradas: la entrada es un objeto tipo feedback
        // Salidas: esta funcion no tiene salidas
        // Resticciones: el objeto feedback tiene que estar crearse correctamente
        public void agregar_Feedback(FeedBack feedBack)
        {
            listaFeedback.Add(feedBack);
        }
        // funcion que agrega un ingrediente a la lista 
        // Entradas: un string con el nuevo ingrediente
        // Salidas: esta funcion no tiene salidas
        // Resticciones: la entrada es un string
        public void agregar_Ingrediente(string ingrediente)
        {
            
        }
        // Funcion que cambia el tiempo estimado del plato por uno nuevo ingresado
        // Entradas: la entrada es un entero 
        // Salidas: esta funcion no tiene salidas
        // Resticciones: la entrada es un entero nuevo distingo de cero y positivo
        public void cambiar_Tiempo_Estimado(int nuevo_tiempo)
        {
            this.tiempoEstimado = nuevo_tiempo;
        }
        // Funcion que cambia el la cantidad de estrellas del plato por uno nuevo ingresado
        // Entradas: esta funcion no tiene entradas
        // Salidas: esta funcion no tiene salidas
        // Resticciones: esta funcion no tiene restricciones   
        
        public void cambiar_Veces_Solicitado()
        {
            this.vecesSolicitada = vecesSolicitada + 1;
        }
    }
}