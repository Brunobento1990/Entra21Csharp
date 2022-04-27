using System;

namespace NumeroCrescente
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3;
            Console.WriteLine("Insira o primerio número");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o segundo número");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o terceiro número");
            n3 = Convert.ToDouble(Console.ReadLine());
            if(n1 > n2 && n1 > n3 && n2 > n3)
            {
                Console.WriteLine("Seu números em ordem crescente são " + n3 + " " + n2 + " " +n1);
            }
            if(n1 > n2 && n1 > n3 && n3 > n2)
            {
                Console.WriteLine("Seus números em ordem crescente são " + n2 + " " + n3 + " " + n1);
            }
            if(n2 > n1 && n2 > n3 && n1 > n3)
            {
                Console.WriteLine("Seus números em ordem crescente são " + n3 + " " + n1 + " " + n2);
            }
            if(n2 > n1 && n2 > n3 && n3 > n1)
            {
                Console.WriteLine("Seus números em ordem crescente são " + n1 + " " + n3 + " " + n2);
            }
            if(n3 > n1 && n3 > n2 && n1 > n2)
            {
                Console.WriteLine("Seus números em ordem crescente são " + n2 + " " + n1 + " " + n3);
            }
            if(n3 > n1 && n3 > n2 && n2 > n1)
            {
                Console.WriteLine("Seus números em ordem crescente são " + n1 + " " + n2 + " " + n3);
            }
            if(n1 == n2 && n1 > n3)
            {
                Console.WriteLine("Há 2 números iguais e a ordem dos números é " + n3 + " " + n1);
            }
            if(n1 == n3 && n1 > n2)
            {
                Console.WriteLine("Há 2 números iguais e a ordem dos números é " + n2 + " " + n1);
            }
            if(n2 == n3 && n2 > n1)
            {
                Console.WriteLine("Há 2 números iguas e a ordem dos números e " + n1 + " " + n2);
            }
        }
    }
}
