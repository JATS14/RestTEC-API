using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
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
            Plato plato1 = new Plato(1500,125,0,10,new List<FeedBack>(),
                "Arroz, Frijoles, Huevo, Tocino, Natilla, Pan", "Gallo Pinto","Desayuno");
            Plato plato2 = new Plato(1000,150,0,5,new List<FeedBack>(),
                 "Tostadas, Mermelada, Mantequilla, Natilla","Tostadas","Desayuno");
            
            Plato plato3 = new Plato(2000,300,0,20,new List<FeedBack>(),
                "Arroz, Frijoles, Platano Maduro, Ensalada,Carne o Pollo",
                                    "Casado","Almuerzo");
            
            Plato plato4 = new Plato(2000,350,0,30,new List<FeedBack>(),
                "Carne, Yuca, Zanahoria, Papa,Cebolla,Chile dulce",
                    "Olla de Carne","Almuerzo");
            
            Plato plato5 = new Plato(1200,150,0,10,new List<FeedBack>(),
                "Manzana, Crema Pastelera, Mantequilla, Natilla",
                                "Tarta de Manzana","Cafe");
            
            Plato plato6 = new Plato(1200,250,0,10,new List<FeedBack>(),
                "Chocolate Amargo, Mantequilla, Huevo, Vainilla, Canela"
                ,"Brownie","Cafe");
            
            Plato plato7 = new Plato(2500,300,0,30,new List<FeedBack>(),
                "Arroz, Camarones, Pollo, Verduras varias",
                            "Arroz con Camarones","Cena");
            
            Plato plato8 = new Plato(3000,400,0,30,new List<FeedBack>(),
                "Carne, Cebolla, Chile Dulce, Ajo",
                    "Bistec Encebollado","Cena");
                
            
            Usuario usuario1 = new Usuario(303660987,"alberto120500@gmail.com","120500", 
                "Alberto", "Espinoza",87898978,"Cartago/Cartago/Los Angeles",12052000);
            
            Usuario usuario2 = new Usuario(102580556,"cristin54@gmail.com","cris54", 
                "Cristina", "Reyes",74894852,"Cartago/Cartago/Tejar",02871994);

            IList<Usuario> listaUsuarios = new List<Usuario>();
            listaUsuarios.Add(usuario1);
            listaUsuarios.Add(usuario2);
            
            
            Administrador host = new Administrador("administracion@gmial.com","123456",
                                                    Lista_Pedidos, listaUsuarios, new List<Chef>());

            
            Menu.agregar_plato_menu(plato1);
            Menu.agregar_plato_menu(plato2);
            Menu.agregar_plato_menu(plato3);
            Menu.agregar_plato_menu(plato4);
            Menu.agregar_plato_menu(plato5);
            Menu.agregar_plato_menu(plato6);
            Menu.agregar_plato_menu(plato7);
            Menu.agregar_plato_menu(plato8);
            
            //Menu.mostrar_Menu();

            //host.menu.eliminar_Plato_Menu(plato2);
            
            Menu.mostrar_Menu();
            host.gestionar_Menu();
            Console.WriteLine("Hacer pedido");

            //host.Lista_Pedidos.Add(Administrador.lista_Usuarios[0].hacer_pedido());
            Console.WriteLine("Cantidad de pedidos: " + host.Lista_Pedidos.Count);
            
            host.gestionar_Pedidos();
            
            Console.WriteLine("~~~~~~~~~~~~~~~~Chefs~~~~~~~~~~~~");
            
            host.agregar_Chef(new Chef("Chef 1","correochef@gmail.com",
                "default", new List<Pedido>()));

            host.pedido_Chef_obtener(0, 0);
            
            host.gestionar_Pedidos();
            
            host.pedido_Chef_Soltar(0, 0);
            
            host.gestionar_Pedidos();
            
            Console.WriteLine("   ");
            Console.WriteLine("||||||||||||||||||||JSON||||||||||||||||||");
            
            string jsonString = JsonSerializer.Serialize(Menu.Lista_Platos);
            Console.WriteLine(jsonString);
            File.WriteAllText(@"C:\Users\adria\RiderProjects\RestTEC\RestTEC\Lista_Platos.json", jsonString);
            
            
            Console.WriteLine("   ");
            Console.WriteLine("=====================FeedBack============");

            string hora = DateTime.Now.ToString("hh:mm");
            string fecha = DateTime.Now.ToString("yy-MM-dd");
            
            FeedBack feedback1 = new FeedBack(usuario1,fecha,hora,5);
            host.usuario_feedback(plato1, feedback1);
        
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}