using System;
using System.Collections.Generic;
using System.Linq;

namespace RestTEC.DB
{
    // Clase menu, es la clase que contiene todos los Platos 
    // La clase con el menu, esta dentro del administrador
    // Esta clase es estatica para poder se accesada por todos en cualquier momento
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

    //  Funcion que agrega un plato al menu
    // Entradas: la entrada es un plato nuevo
    // Salidas: esta funcion no tiene salida
    // Resticciones: el plato tiene que estar correctamente creado
    public static void agregar_plato_menu(Plato plato)
    {
        Lista_Platos.Add(new Plato(plato.precio, plato.cantidadCalorias, plato.vecesSolicitada, plato.tiempoEstimado,
            plato.ListaFeedback, plato.listaIngredientes, plato.nombre, plato.tipo));

    }

    // Funcion que elimina un plato del menu
    // Entradas: la entrada es el plato que se desea eliminar
    // Salidas: esta funcion no tiene salidas
    // Resticciones: el plato que se ingresa, tiene que estar en el menu
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

    // Funcion que muestra rapidamente los platos en el menu, con pocos detalles en la consola
    // Entradas: esta funcion no tiene entrada
    // Salidas: esta funcion no tiene salidas
    // Resticciones: no tien resticciones
    public static void mostrar_Menu()
    
    {
        for (int i = 0; i < Lista_Platos.Count; i++)
        {
            Console.WriteLine(Lista_Platos[i].nombre);
        }
    }
    
    // Funcion que retorna la lista de platos del menu
    // Entradas: esta funcion no tiene entradas
    // Salidas: la salida es la Ilistd de los paltos del sistema
    // Resticciones: no tiene restricciones
    public static IList<Plato> obtener_Menu()
    {
        return Lista_Platos;
    }

    public static void Instance()
    {
        
    }
    // Funcion que busca un plato es los del sistema 
    //      La busqueda se hace por nombre
    // Entradas:la entrada es el plato a buscar
    // Salidas: si encuentra un plato en el sistema este es la salida
    // Resticciones: El nombre del plato tiene que tener un valor
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