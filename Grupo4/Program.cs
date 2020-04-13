using System;

namespace Grupo4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Somos el grupo 4");
            
            string mayus = uppercase("test de la funcion uppercase");
            Console.WriteLine(mayus);

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
    }
}
