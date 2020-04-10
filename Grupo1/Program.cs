using System;

namespace Grupo1
{
    class Program
    {
        static int SumarNums(int numero1, int numero2)
        {
            int resultado = numero1 + numero2;
            return resultado;
        }
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Batman es el mejor");
            int result = SumarNums(10, 5);
            Console.WriteLine(result);

        }
        
        
    }
}


