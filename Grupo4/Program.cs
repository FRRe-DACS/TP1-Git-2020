using System;

namespace Grupo4
{
    class Program
    {
        static void Main( string[] args )
        {
            
            Console.WriteLine("Somos el grupo 4");
            
            string mayus = uppercase("test de la funcion uppercase");
            Console.WriteLine(mayus);

            int numero;

            Console.Write("\nIngrese un número para calcular el factorial: ");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEl factorial del numero es: " + factorial(numero));

            Console.WriteLine(" \nEsta es la suma de el número dado más su factorial: ");
            Console.WriteLine(" \nLa suma da: " + suma(numero,factorial(numero)));

            Console.Write("\nIngrese un número conocer si es par o impar: ");
            numP = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEl número " + numP + " es: " + parimpar(numP));
        }

        
        /*
           FUNCION PARA TRANSFORMAR TEXTO EN MAYUSCULAS
           AUTOR: MIGUEL BRITOS
        */
        static string uppercase(string palabra)
        {
            string input = palabra;
            string result = string.Empty;
            for(int i=0;i<input.Length;i++){
                if(input[i]>='a'&&input[i]<='z'){
                    result+=(char)(input[i]-32);
                }else{
                    result+=input[i];
                }
            }
            return result;
        }

        /*
            Función factorial
            Autor: Montero Facundo
        */
        static int factorial(int n)
        {
            if(n>1)
            {
                n = n * factorial(n-1);
            }
            return n;
        }

        /*
            Función sumar numero mas su factorial
            Autor: Andrik Ivan
        */
        static int suma(int n, int m)
        {
            n=n+m;
            return n;
        }

        /*
           Función para conocer si un número es par o impar
           Autor: Horacio Soto
        */
        static string parimpar(int numP)
        {
            string result = 'impar';
            if(numP%2==0){
                result = 'par';
            }
            return result;
        }
    }
}
