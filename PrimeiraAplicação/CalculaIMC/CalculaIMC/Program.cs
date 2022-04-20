using System;

namespace CalculaIMC
{
    class Program
    {
        static void Main(string[] args)
        {

            // Calcula IMC

            Console.WriteLine("Insira sua altura");
            double alt = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira seu peso");
            double peso = Convert.ToDouble(Console.ReadLine());

            double result = Math.Round(peso / (alt * alt));

            Console.WriteLine(" seu IMC é " + result);

           

        }
    }
}
