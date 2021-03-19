using System.Security;

namespace RestTEC.DB
{
    // Clase feedback, es la clase que encapsula todos la informacion necesaria para hacer feedback
    // Objetos de este tipo solo los pueden crear la clase Usuario
    public class FeedBack
    {
        //Atributos
        public Usuario usuario;
        public int fecha;
        public int hora;
        public int estrellas;

        //Constructor, getters y setters
        public FeedBack(Usuario usuario, int fecha, int hora, int estrellas)
        {
            this.usuario = usuario;
            this.fecha = fecha;
            this.hora = hora;
            this.estrellas = estrellas;
        }

        public Usuario Usuario
        {
            get => usuario;
            set => usuario = value;
        }

        public int Fecha
        {
            get => fecha;
            set => fecha = value;
        }

        public int Hora
        {
            get => hora;
            set => hora = value;
        }

        public int Estrellas
        {
            get => estrellas;
            set => estrellas = value;
        }
        
                //Funcionalidad FeedBack
                
        // 
        // Entradas:
        // Salidas:
        // Resticciones:
        public void asignar_Fecha(int fecha)
        {
            this.fecha = fecha;
        }
        // 
        // Entradas:
        // Salidas:
        // Resticciones:
        public void asignar_Hora(int hora)
        {
            this.hora = hora;
        }
        // 
        // Entradas:
        // Salidas:
        // Resticciones:
        public void asignar_Estrellas(int estrellas)
        {
            this.estrellas = estrellas;
        }
    }
}
