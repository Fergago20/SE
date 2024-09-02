using UseIf.models;

namespace UseIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Decir si es nino, joven adulto
            int edad = 0;
            Evaluate evaluate = new Evaluate();

            Console.WriteLine("Evaluar edad");
            Console.WriteLine("Ingrese su edad");
            try
            {
                edad = int.Parse(Console.ReadLine());
                Console.WriteLine(evaluate.EvalAge(edad));
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            
           
        }
    }
}
