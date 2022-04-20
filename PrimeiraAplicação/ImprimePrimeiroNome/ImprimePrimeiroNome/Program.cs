using System;

namespace ImprimePrimeiroNome
{
    class Program
    {
        static void Main(string[] args)
        {
            // exercicio para escrever nome

            string Pnome, UltNome;
            Console.WriteLine("Escreva seu primeiro nome");
            Pnome = Console.ReadLine();
            Console.WriteLine("Escreva seu último nome");
            UltNome = Console.ReadLine();
            Console.WriteLine("Seu primeiro nome é " + Pnome + " e seu último nome é " + UltNome);
        }
    }
}
