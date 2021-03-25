namespace RestTEC.DB
{
    // Clase pedido, es la clase encargada de contener la informacion de todos los pedidos
    // Objetos de este tipo, son creadas por los usuarios, pero controladas por los chefs
    public class Pedido
    {
        //Atributos
        public Chef chef_Asignado;
        public Plato plato;
        public int tiempo_estimado_finalizacion;

        //Constructor, getters y setters
        public Pedido(Chef chefAsignado, Plato plato, int tiempoEstimadoFinalizacion)
        {
            chef_Asignado = chefAsignado;
            this.plato = plato;
            tiempo_estimado_finalizacion = plato.tiempoEstimado;
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
                
                    //Funcionalidad Pedido
                    
        // Funcion que asigna un chef al pedido
        // Entradas: la entrada es un chef a asignar
        // Salidas: esta funcion no tiene salidas
        // Resticciones: el chef tiene que estar en la lista de chefs           
        public void asignar_chef(Chef chef)
        {
            chef_Asignado = chef;
        }
        // Funcion que calcula el tiempo estimado para este plato en especifico
        // Entradas: la funion no tiene entradas
        // Salidas: la salida es un entero con el tiempo estimado
        // Resticciones: esta funcion no tiene restricciones
        public int calcular_Tiempo()
        {
            return plato.tiempoEstimado;
        }
    }
}