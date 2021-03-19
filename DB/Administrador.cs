namespace RestTEC.DB
{
    public class Administrador
    {
        public string correo;
        private string contrasena;
        public Pedido[] Lista_Pedidos;

        public Administrador(string correo, string contrasena, Pedido[] listaPedidos)
        {
            this.correo = correo;
            this.contrasena = contrasena;
            Lista_Pedidos = listaPedidos;
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
            get => Lista_Pedidos;
            set => Lista_Pedidos = value;
        }
    }
}