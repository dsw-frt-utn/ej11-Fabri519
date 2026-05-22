using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    private Dictionary<int, Alumno> _dic = [];
    public void AgregarAlumno(int legajo, Alumno alumno) => _dic.Add(legajo, alumno);
    public Alumno? BuscarAlumno(int legajo) => _dic.TryGetValue(legajo, out var alumno) ? alumno : null;
    public Dictionary<int, Alumno> ObtenerDiccionario() => _dic;
    public void EliminarAlumno(int legajo) => _dic.Remove(legajo);

}
