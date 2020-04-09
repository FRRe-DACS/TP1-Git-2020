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

            string mensaje1;
            mensaje1 = minusculas("TEXTO EN MAYUSCULAS");
            Console.WriteLine(mensaje1);
        }

        static string escribir()
        {
            string mensaje;
            Console.WriteLine("ingrese el mensaje");
            mensaje = Console.ReadLine();
            return mensaje;
        }

        // funcion que convierte a minusculas un string dado
        public static string minusculas(string cadena){
            string salida = cadena.ToLower();
            return salida; 
        }
        static public int Add(int x, int y)//Alejandro Nadal
        { 
            int result = x + y;
            return result;
        }

        static void int Add(int x, int y) //Nicolas Zini
        {
            int result = x * y;
            return result;
        }
    }
}
