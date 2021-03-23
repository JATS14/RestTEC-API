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
                
        // 
        // Entradas:
        // Salidas:
        // Resticciones:
        public void asignar_Fecha(string fecha)
        {
            this.fecha = fecha;
        }
        // 
        // Entradas:
        // Salidas:
        // Resticciones:
        public void asignar_Hora(string hora)
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
