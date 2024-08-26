using Sesion2.Clases;

namespace ConsoleApp1
{
    //Leer los datos de una persona y decir si es mayor o menor de edad
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            DateTime fechaNac;
            Persona per=new Persona();

            Console.Write("Dime tu nombre: ");
            nombre= Console.ReadLine();
            Console.Write("En que fecha naciste: ");
            fechaNac = DateTime.Parse(Console.ReadLine());

            per.Nombre = nombre;
            per.FechaNac = fechaNac;
            Console.WriteLine(per.EvaluarEdad());
        }
    }
}
