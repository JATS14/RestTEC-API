using System;
using System.Linq;

namespace RestTEC.DB
{
    // Clase menu, es la clase que contiene todos los Platos 
    // La clase con el menu, esta dentro del administrador
    public sealed class Menu
    {
    //Atributos
    public Plato[] Lista_Platos;

    //Constructor, getters y setters
    public Menu(Plato[] listaPlatos)
    {
        Lista_Platos = listaPlatos;
    }

    public Plato[] ListaPlatos
    {
        get => Lista_Platos;
        set => Lista_Platos = value;
    }

    //Funcionalidad Menu

    // 
    // Entradas:
    // Salidas:
    // Resticciones:
    public void agregar_plato_menu(Plato plato)
    {
        Lista_Platos.Append(plato);
    }

    // 
    // Entradas:
    // Salidas:
    // Resticciones:
    public void eliminar_Plato_Menu(Plato plato)
    {
        for (int i = 0; i < Lista_Platos.Length; i++)
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
    public void mostrar_Menu()
    {
        for (int i = 0; i < Lista_Platos.Length; i++)
        {
            Console.WriteLine(Lista_Platos[i].nombre);
        }
    }
    }
}