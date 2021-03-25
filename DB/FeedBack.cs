using System.Security;

namespace RestTEC.DB
{
    // Clase feedback, es la clase que encapsula todos la informacion necesaria para hacer feedback
    // Objetos de este tipo solo los pueden crear la clase Usuario
    public class FeedBack
    {
        //Atributos
        public Usuario usuario;
        public string fecha;
        public string hora;
        public int estrellas;

        //Constructor, getters y setters
        public FeedBack(Usuario usuario, string fecha, string hora, int estrellas)
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

        public string Fecha
        {
            get => fecha;
            set => fecha = value;
        }

        public string Hora
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
                
        // Funcion que asigna una fecha ingresada al esta clase
        // Entradas: la entrada es un string con formato yy:mm:dd. Este formato lo proporsiona el IDLE
        // Salidas: esta funcion no tiene salidas
        // Resticciones: la fecha tiene que tener el formato indicado, y en string
        public void asignar_Fecha(string fecha)
        {
            this.fecha = fecha;
        }
        // Funcion que asigna una hora ingresada al esta clase
        // Entradas: la entrada es un string en formato hh:mm
        // Salidas: esta funcion no tiene salidas
        // Resticciones: el string de entrada tiene que tener el formato, el fomrmato lo crea el IDLE 
        public void asignar_Hora(string hora)
        {
            this.hora = hora;
        }
        // Funcion que asigna las estrellas ingresadas a la clase
        // Entradas: la entrada es un entero con la cantidad de estrellas asignadas
        // Salidas: la salida de esta funcion es void
        // Resticciones: la cantidad de estrellas va de un valor de 1 a 5
        public void asignar_Estrellas(int estrellas)
        {
            this.estrellas = estrellas;
        }
    }
}
