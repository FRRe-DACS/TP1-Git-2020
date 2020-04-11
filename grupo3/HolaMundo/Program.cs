using System;

namespace grupo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static int factorial(int n){
            if(n==0){
                return 1;
            }else{
                return n*factorial(n-1);
            }
        }
      
        static void imprimirEntrada(){
            string entrada;
            Console.Write("Ingrese algo: ");
            entrada = Console.ReadLine();

            Console.WriteLine(entrada);
        }  

        static void suma(int a,int b){
            int c = a + b;
            Console.WriteLine(c);
        }

    }
}
