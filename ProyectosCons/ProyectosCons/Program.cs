using ProyectosCons.Clase;
namespace ProyectosCons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string seleccion;
            string nombre, apellido, codigo, direccion, sexo;
            DateTime nacimiento;
            Cedula cel = new Cedula();
            Console.WriteLine("Ingrese sus datos personales.");
            do
            {
                Console.Clear();
                Console.Write("Nombre: ");
                nombre = Console.ReadLine();
                Console.Write("Apellido: ");
                apellido = Console.ReadLine();
                Console.Write("Codigo de cedula: ");
                codigo = Console.ReadLine();
                Console.Write("Nacimiento: ");
                nacimiento = DateTime.Parse(Console.ReadLine());
                Console.Write("Sexo: ");
                sexo = Console.ReadLine();

                cel.Nombre = nombre;
                cel.Apellido = apellido;
                cel.Codigo = codigo;
                cel.Nacimiento = nacimiento;
                cel.Sexo = sexo;

                Console.WriteLine($"Nombre: {nombre}");
                Console.WriteLine($"Apellido: {apellido}");
                Console.WriteLine($"Cedula: {codigo}");
                Console.WriteLine($"Sexo: {sexo}");
                Console.WriteLine($"Nacimiento: {nacimiento}");

                Console.WriteLine("Desea digitar otra cedula? si/no.");
                seleccion = Console.ReadLine();

            } while (seleccion.Equals("Si", StringComparison.OrdinalIgnoreCase));
        }
    }
}
