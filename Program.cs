using System;

namespace PrimeraAplicacion
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el primer número");
            int numero1= int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo número");
            int numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine(" Estos Dos números se sumarán jejeje");
            Console.WriteLine(" ");
            int numero3 = numero1 + numero2;
            Console.WriteLine(numero3);




        }
    }
}       