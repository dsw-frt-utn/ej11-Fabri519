using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList _alumlist = new();
        _alumlist.AgregarAlumno(new Alumno(1, "Juan", 20));
        _alumlist.AgregarAlumno(new Alumno(2, "Maria", 18));
        _alumlist.AgregarAlumno(new Alumno(3, "Pedro", 22));
        Console.WriteLine("Alumnos:");
        foreach (var a in _alumlist.ObtenerAlumnos())
        {
            Console.WriteLine(a);
        }

       Alumno encontrado = _alumlist.BuscarAlumnos("Maria");
        Console.WriteLine($"Alumno: {encontrado}");

        if (_alumlist.BuscarAlumnos("Jose") is null) Console.WriteLine("No existe");
        Alumno alumnoAEliminar = _alumlist.BuscarAlumnos("Juan");
        _alumlist.EliminarAlumno(alumnoAEliminar);
        Console.WriteLine("Alumno eliminado con éxito.");
        foreach (var a in _alumlist.ObtenerAlumnos())
        {
            Console.WriteLine(a);
        }


    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary dic = new();
        dic.AgregarAlumno(56142, new Alumno(1, "Jorge", 8));
        dic.AgregarAlumno(56450, new Alumno(1, "Juan", 8.2));
        dic.AgregarAlumno(56000, new Alumno(1, "Pablo", 8.5));
       
        Console.WriteLine("Buscar por clave:");
        Alumno? encontrado = dic.BuscarAlumno(56142);
        Console.WriteLine($"Alumno encontrado {encontrado}");
        Console.WriteLine("\n");
        Console.WriteLine("Buscar por clave un legajo que no existe:");
        Alumno? noExiste = dic.BuscarAlumno(56182);
        Console.WriteLine(noExiste?.ToString() ?? "No existe");
        Console.WriteLine("\n");
        Console.WriteLine("Eliminar alumno por clave:");
        dic.EliminarAlumno(56000);
        foreach (var a in dic.ObtenerDiccionario())
            Console.WriteLine($"Legajo: {a.Key} - {a.Value}");

    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {

    }
}
