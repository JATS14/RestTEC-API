namespace RestTEC.DB
{
    public class Chef
    {
        public string correo;
        private string contrasena;
        public Pedido[] lista_pedidos;
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
    }

}