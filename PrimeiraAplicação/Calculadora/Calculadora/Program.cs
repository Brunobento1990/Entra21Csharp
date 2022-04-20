using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculadora

            Console.WriteLine("Digite o primeiro número");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Agora insira o operador");
            string opera = Console.ReadLine();
            double result;

            if (opera == "+")
            {
                result = n1 + n2;
                Console.WriteLine("A soma dos valores é " + result);
            }
            if (opera == "-")
            {
                result = n1 - n2;
                Console.WriteLine("A subtração dos valores é " + result);
            }
            if (opera == "*")
            {
                result = n1 * n2;
                Console.WriteLine("A multiplicação dos valores é " + result);
            }
            if (opera == "/")
            {
                result = n1 / n2;
                Console.WriteLine("A divisão dos valores é " + result);
            }
        }
    }
}
