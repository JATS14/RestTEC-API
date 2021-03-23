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
        public IList<string> listaFeedback;
        public IList<string> listaIngredientes;
        public string nombre;
        public string tipo;

        //Constructor, getters y setters
        public Plato(int precio, int cantidadCalorias, int vecesSolicitada, int tiempoEstimado, 
            IList<string> listaFeedback, IList<string> listaIngredientes, string nombre, string tipo)
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

        public IList<string> ListaFeedback
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
        
        // 
        // Entradas:
        // Salidas:
        // Resticciones:
        public void cambiar_Precio(int precio)
        {
            this.precio = precio;
        }
        // 
        // Entradas:
        // Salidas:
        // Resticciones:
        public void agregar_Feedback(FeedBack feedBack)
        {
            
        }
        // 
        // Entradas:
        // Salidas:
        // Resticciones:
        public void agregar_Ingrediente(string ingrediente)
        {
            
        }
        // 
        // Entradas:
        // Salidas:
        // Resticciones:
        public void cambiar_Tiempo_Estimado(int nuevo_tiempo)
        {
            this.tiempoEstimado = nuevo_tiempo;
        }
        // 
        // Entradas:
        // Salidas:
        // Resticciones:    
        
        public void cambiar_Veces_Solicitado()
        {
            this.vecesSolicitada = vecesSolicitada + 1;
        }
    }
}