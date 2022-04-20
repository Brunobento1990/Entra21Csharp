using System;

namespace CalculaMaiorIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calcular maior idade
            Console.WriteLine("Insira seu nome");
            String nome = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Insira sua idade");
            int ida = Convert.ToInt32(Console.ReadLine());

            if (ida >= 18)
            {
                Console.WriteLine(nome + " você é maior de idade");
            }
            else
            {
                Console.WriteLine(nome + " Você é menor de idade");
            }
        }
    }
}
