using System;

namespace Grupo4
{
    class Program
    {
        static int factorial(int n)
        {
            int fac = 1;

            for(int i = 1; i<=n;i++)
                fac = fac * i;
            
            return fac;
        }
        static void Main(string[] args)
        {
            int numero;

            for(int x = 1;x<=10;x++){
                Console.Write("\nIngrese el número");
                numero = int.Parse(Console.ReadLine());

                Console.Write("\nEl factorial del numero es: " + factorial(numero));
            }

            Console.ReadKey();
        }
    }
}
