using System;
using System.Collections.Generic;
using System.Linq;

namespace RestTEC.DB
{
    // Clase menu, es la clase que contiene todos los Platos 
    // La clase con el menu, esta dentro del administrador
    static class Menu
    { 
    //Atributos
    public static IList<Plato> Lista_Platos;

    //Constructor, getters y setters
    static Menu()
    {
        
        Lista_Platos =  new List<Plato>();
        
    }
    public static IList<Plato> ListaPlatos
    {
        get => Lista_Platos;
        set => Lista_Platos = value;
    }
    //Funcionalidad Menu

    // 
    // Entradas:
    // Salidas:
    // Resticciones:
    public static void agregar_plato_menu(Plato plato)
    {
        Lista_Platos.Add(new Plato(plato.precio, plato.cantidadCalorias, plato.vecesSolicitada, plato.tiempoEstimado,
            plato.ListaFeedback, plato.listaIngredientes, plato.nombre, plato.tipo));

    }

    // 
    // Entradas:
    // Salidas:
    // Resticciones:
    public static void eliminar_Plato_Menu(Plato plato)
    {
        for (int i = 0; i < Lista_Platos.Count; i++)
        {
            if (Lista_Platos[i].nombre == plato.nombre)
            {
                Lista_Platos = Lista_Platos.Where(e => e != Lista_Platos[i]).ToArray();
            }
        }
    }

    // 
    // Entradas:
    // Salidas:
    // Resticciones:
    public static void mostrar_Menu()
    
    {
        for (int i = 0; i < Lista_Platos.Count; i++)
        {
            Console.WriteLine(Lista_Platos[i].nombre);
        }
    }
    
    // 
    // Entradas:
    // Salidas:
    // Resticciones:
    public static IList<Plato> obtener_Menu()
    {
        return Lista_Platos;
    }

    public static void Instance()
    {
        
    }
    // 
    // Entradas:
    // Salidas:
    // Resticciones:
    public static Plato buscar_PLato(Plato plato)
    {
        for (int i = 0; i < Lista_Platos.Count; i++)
        {
            if (Lista_Platos[i].nombre == plato.nombre)
            {
                return Lista_Platos[i];
            }
        }
        
        return null;
    }
    
    
    
    }
    
}