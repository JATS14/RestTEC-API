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
            Pedido[] Lista_Pedidos = {};
            Plato plato1 = new Plato(100,100,0,60,new string[]{},
                new string[]{"Sal", "pimienta", "carne", "cosas", "leche", "huevos"},
                        "Plato 1","Desayuno");
            Plato plato2 = new Plato(200,200,0,50,new string[]{},
                new string[]{"Sal", "oregano", "pasta", "cosas"},"Plato 2","Almuerzo");
            Plato[] Lista_Platos = {plato1,plato2};
            Menu menu = new Menu(Lista_Platos);
            
            Usuario usuario1 = new Usuario(3088088,"usuario1@gmail.com","contrasena1",
                        "Nombre1", "apellidos1",8888888,"Direccion1",2000112121);

            Usuario[] listaUsuarios = new Usuario[] {usuario1};
            
            Administrador host = new Administrador("correo@gmial.com","123456",
                                                    Lista_Pedidos,menu,listaUsuarios);
            
            host.gestionar_Menu();
            
            host.menu.eliminar_Plato_Menu(plato2);
            
            host.menu.mostrar_Menu();
            
            Console.WriteLine("Hacer pedido");

            host.lista_Usuarios[0].hacer_pedido();
            
            
            
            
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}