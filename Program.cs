using System;

namespace PrimeraAplicacion
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            
            Console.WriteLine("Introduzca el primer número a sumar");
            double numero1= double.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo número a sumar");
            double numero2 = double.Parse(Console.ReadLine());
            Console.WriteLine("El resultado de la suma es : " + numero1+numero2);

            



        }
    }
}       