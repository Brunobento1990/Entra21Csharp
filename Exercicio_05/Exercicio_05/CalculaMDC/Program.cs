using System;

namespace CalcularMMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---> Calcular Máximo Divisor Comum de 3 números inteiros <---");
            Console.WriteLine();
            Console.WriteLine("---> Insira o 1° número !");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---> Insira o 2° número !");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---> Insira o 3° número !");
            int n3 = Convert.ToInt32(Console.ReadLine());
            int Result = CalcularMMC(n1, n2, n3);
            Console.WriteLine($"---> O Máximo Divisor Comum de {n1} , {n2} , {n3} é {Result}");

        }
        static int CalcularMMC(int n1, int n2, int n3)
        {

            int Result = 1, Divisor = 2;
            while (n1 > 1 || n2 > 1 || n3 > 1)
            {

                if (n1 % Divisor == 0 && n2 % Divisor == 0 && n3 % Divisor == 0)
                {
                    Result *= Divisor;
                   
                }
                if (n1 % Divisor == 0)
                {
                    n1 /= Divisor;
                    
                }
                if (n2 % Divisor == 0)
                {
                    n2 /= Divisor;

                }
                if (n3 % Divisor == 0)
                {
                    n3 /= Divisor;
                }
                
                else
                {
                    Divisor++;
                }

            }
            return Result;
        }
    }
}
