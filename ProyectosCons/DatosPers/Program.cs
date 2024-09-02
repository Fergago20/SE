using DatosPers;
using System.Runtime.ConstrainedExecution;
namespace DatosPers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona per = new Persona();
            string nombre, apellido, seleccion;
            DateTime nacimiento;
            bool sexo;
            float altura, peso;
            int dias;
            Console.WriteLine("Ingrese Nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            apellido = Console.ReadLine();
            
            Console.Write("Nacimiento: ");
            nacimiento = DateTime.Parse(Console.ReadLine());
            Console.Write("Peso en libras: ");
            peso = float.Parse(Console.ReadLine());
            Console.Write("Altura en metros: ");
            altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el la letra F si es mujer, M si es Hombre");
            seleccion = Console.ReadLine().ToUpper();

            if(seleccion=="F")
            {
                sexo = true;
            } else if (seleccion == "M")
            {
                sexo = false;
            }
            else { Console.WriteLine("Error de digito."); sexo = false; }

            per.Nombre = nombre;
            per.Apellido = apellido;
            per.Nacimiento = nacimiento;
            per.Estatura = altura;
            per.Peso = peso;
            per.Sexo = sexo;

            dias=per.EdadDias();

            Console.Write($"La cantidad total de dias de vida es: {dias}.");
        }
    }
}
