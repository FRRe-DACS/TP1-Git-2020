using System;

namespace grupo2
{
    class Program
    {


        static string escribir()
        {
            string mensaje;
            Console.WriteLine("ingrese el mensaje");
            mensaje = Console.ReadLine();
            return mensaje;
        }

        static string transformarUppercase(string palabra){
            return palabra.ToUpper();
             
        }


            static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string mensaje;
            mensaje = escribir();
            mensaje = transformarUppercase(mensaje);
            Console.WriteLine(mensaje);
        
        }
   
    }

}
