using System;

namespace PrimeraAplicacion
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            const double PI = 3.1416;
            Console.WriteLine("Introduzca la medida del radio");
            double radio= double.Parse(Console.ReadLine());
            double area = radio * radio * PI;
            Console.WriteLine(" El area del circulo es la siguiente {0}", area);
            




        }
    }
}       