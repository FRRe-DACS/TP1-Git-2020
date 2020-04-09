using System;

namespace grupo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string mensaje;
            mensaje = escribir();
            Console.WriteLine(mensaje);
        }

        static string escribir()
        {
            string mensaje;
            Console.WriteLine("ingrese el mensaje");
            mensaje = Console.ReadLine();
            return mensaje;
        }
    }
}
