using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RestTEC.DB;

namespace RestTEC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Menu.Instance();
            IList<Pedido> Lista_Pedidos = new List<Pedido>();
            Plato plato1 = new Plato(100,100,0,60,new string[]{},
                new string[]{"Sal", "pimienta", "carne", "cosas", "leche", "huevos"},
                        "Plato 1","Desayuno");
            Plato plato2 = new Plato(200,200,0,50,new string[]{},
                new string[]{"Sal", "oregano", "pasta", "cosas"},"Plato 2","Almuerzo");
            
            
            Usuario usuario1 = new Usuario(3088088,"usuario1@gmail.com","contrasena1",
                        "Nombre1", "apellidos1",8888888,"Direccion1",2000112121);

            IList<Usuario> listaUsuarios = new List<Usuario>();
            listaUsuarios.Add(usuario1);
            
            
            Administrador host = new Administrador("correo@gmial.com","123456",
                                                    Lista_Pedidos, listaUsuarios, new List<Chef>());

            
            Menu.agregar_plato_menu(plato1);
            Menu.agregar_plato_menu(plato2);
            
            //Menu.mostrar_Menu();

            //host.menu.eliminar_Plato_Menu(plato2);
            
            Menu.mostrar_Menu();
            host.gestionar_Menu();
            Console.WriteLine("Hacer pedido");

            host.Lista_Pedidos.Add(host.lista_Usuarios[0].hacer_pedido());
            Console.WriteLine("Cantidad de pedidos: " + host.Lista_Pedidos.Count);
            
            host.gestionar_Pedidos();
            
            Console.WriteLine("~~~~~~~~~~~~~~~~Chefs~~~~~~~~~~~~");
            
            host.agregar_Chef(new Chef("chef1","correochef@gmail.com","fefault", new List<Pedido>()));

            host.pedido_Chef_obtener(0, 0);
            
            host.gestionar_Pedidos();
            
            host.pedido_Chef_Soltar(0, 0);
            
            host.gestionar_Pedidos();
            
            
           // CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}