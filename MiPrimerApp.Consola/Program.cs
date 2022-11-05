using MiPrimerApp.Consola.Clases;
using System.Security.Cryptography.X509Certificates;

namespace MiPrimerApp.Consola
{
    internal class Program
    {

        public static int numero1 = 20;
        public static int numero2 = 10;




        static void Main(string[] args)
        {
            var calcular = new Calculos(); // Sumar(10,20);
            
            Console.WriteLine("Hello, World! :" );
            int resultado = calcular.Sumar(numero1,numero2);

            Console.WriteLine(resultado);


            calcular.Multiplicar(numero1, numero2);
           //calcular._re = calcular.Sumar(numero2, numero1);
            //calcular.Resultado = calcular.Sumar(numero2 , numero1);

            Console.WriteLine(calcular.Resultado);


        }


    }
}