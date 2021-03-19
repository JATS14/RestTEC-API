namespace RestTEC.DB
{
    public class Pedido
    {
        public Chef chef_Asignado;
        public Plato plato;
        public int tiempo_estimado_finalizacion;

        public Pedido(Chef chefAsignado, Plato plato, int tiempoEstimadoFinalizacion)
        {
            chef_Asignado = chefAsignado;
            this.plato = plato;
            tiempo_estimado_finalizacion = tiempoEstimadoFinalizacion;
        }

        public Chef ChefAsignado
        {
            get => chef_Asignado;
            set => chef_Asignado = value;
        }

        public Plato Plato
        {
            get => plato;
            set => plato = value;
        }

        public int TiempoEstimadoFinalizacion
        {
            get => tiempo_estimado_finalizacion;
            set => tiempo_estimado_finalizacion = value;
        }
    }
}