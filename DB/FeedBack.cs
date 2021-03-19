namespace RestTEC.DB
{
    public class FeedBack
    {
        public Usuario usuario;
        public int fecha;
        public int hora;
        public int estrellas;

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
    }
}
