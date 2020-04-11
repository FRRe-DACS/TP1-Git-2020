using System;

namespace grupo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

	      static void UpperC(string inputmsj)
        {
            inputmsj=inputmsj.ToUpper();
            Console.WriteLine(inputmsj);
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
