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
            var c1 = new Carlos();
            Console.WriteLine($"#####, {c1.ReturnMessage()}");
            Console.WriteLine("###########");
            int result = SumarNums(10, 5);
            Console.WriteLine(result);
            string Nombre = Funcion("###########");
            Console.WriteLine(Nombre);
        }
        
        
    }
}