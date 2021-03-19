namespace RestTEC.DB
{
    // Clase encargada de guardar la informacion de los chefs
    // Esta clase tambien esta encargada de manejar los pedidos por chef
    public class Chef {
        //Atributos
        public string correo;
        private string contrasena;
        public Pedido[] lista_pedidos;
        
        //Constructor, getters y setters
        public Chef(string correo, string contrasena, Pedido[] listaPedidos)
        {
            this.correo = correo;
            this.contrasena = contrasena;
            lista_pedidos = listaPedidos;
        }
        public string Correo
        {
            get => correo;
            set => correo = value;
        }
        public string Contrasena
        {
            get => contrasena;
            set => contrasena = value;
        }

        public Pedido[] ListaPedidos
        {
            get => lista_pedidos;
            set => lista_pedidos = value;
        }
                //Funcionalidad Chef
                
        // 
        // Entradas:
        // Salidas:
        // Resticciones:
        public void tomar_Pedido()
        {
                    
        }
        // 
        // Entradas:
        // Salidas:
        // Resticciones:
        public void soltar_pedido()
        {
            
        }
    }

}