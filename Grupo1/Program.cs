using System;

namespace Grupo1
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Carlos();
            Console.WriteLine($"Hello, {c1.ReturnMessage()}");
            Console.WriteLine("Batman es el mejor");
        }
    }
}