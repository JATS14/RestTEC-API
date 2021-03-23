using System.Collections.Generic;

namespace RestTEC.DB
{
    // Clase encargada de guardar la informacion de los chefs
    // Esta clase tambien esta encargada de manejar los pedidos por chef
    public class Chef {
        //Atributos
        public string nombre;
        public string correo;
        private string contrasena;
        public IList<Pedido> lista_pedidos;
        
        //Constructor, getters y setters
        public Chef(string nombre,string correo, string contrasena, IList<Pedido> listaPedidos)
        {
            this.nombre = nombre;
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

        public IList<Pedido> ListaPedidos
        {
            get => lista_pedidos;
            set => lista_pedidos = value;
        }
                //Funcionalidad Chef
                
        // 
        // Entradas:
        // Salidas:
        // Resticciones:
        public void tomar_Pedido(Pedido nuevo_pedido)
        {
            lista_pedidos.Add(nuevo_pedido);
        }
        // 
        // Entradas:
        // Salidas:
        // Resticciones:
        public Pedido soltar_pedido(int numero)
        {
            if (lista_pedidos[numero] != null)
            {
                Pedido x = lista_pedidos[numero];
                lista_pedidos.RemoveAt(numero);
                return x;
            }

            return null;
        }
        
        // 
        // Entradas:
        // Salidas:
        // Resticciones:
        public int calcular_tiempo()
        {
            if (ListaPedidos.Count == 0)
            {
                return 0;
            }
            else
            {
                int tiempo_estimado = 0;
                for (int i = 0; i < ListaPedidos.Count; i++)
                {
                    tiempo_estimado = tiempo_estimado + lista_pedidos[i].tiempo_estimado_finalizacion;
                }

                return tiempo_estimado;
            }
        }
    }

}