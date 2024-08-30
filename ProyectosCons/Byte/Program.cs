namespace Byte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Tamaño de byte: {sizeof(byte)} bytes");
            Console.WriteLine($"Tamaño de sbyte: {sizeof(sbyte)} bytes");
            Console.WriteLine($"Tamaño de short: {sizeof(short)} bytes");
            Console.WriteLine($"Tamaño de ushort: {sizeof(ushort)} bytes");
            Console.WriteLine($"Tamaño de int: {sizeof(int)} bytes");
            Console.WriteLine($"Tamaño de uint: {sizeof(uint)} bytes");
            Console.WriteLine($"Tamaño de long: {sizeof(long)} bytes");
            Console.WriteLine($"Tamaño de ulong: {sizeof(ulong)} bytes");
            Console.WriteLine($"Tamaño de float: {sizeof(float)} bytes");
            Console.WriteLine($"Tamaño de double: {sizeof(double)} bytes");
            Console.WriteLine($"Tamaño de decimal: {sizeof(decimal)} bytes");
            Console.WriteLine($"Tamaño de char: {sizeof(char)} bytes");
            Console.WriteLine($"Tamaño de bool: {sizeof(bool)} bytes");
        }
    }
}
