using System;

namespace Grupo1
{
    class Program
    {
        static string Funcion(string Nombre)
        {
            if (string.IsNullOrEmpty(Nombre))
            {
                return string.Empty;
            }
                return char.ToUpper(Nombre[0]) + Nombre.Substring(1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Batman es el mejor");
            string Nombre = Funcion("selene");
            Console.WriteLine(Nombre);
        }
    }
}