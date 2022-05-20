using System;

namespace AdivinhaNumeroAle
{
    class Program
    {
        static void Main(string[] args)
        {
            Random NumCerto = new Random();
            int Tentativa = 1, num = NumCerto.Next(1,10);
            Console.WriteLine("---> Digite o número a ser comparado !!!");
            int NumTentativa = Convert.ToInt32(Console.ReadLine());
            while(num != NumTentativa)
            {

                if(NumTentativa > num)
                {
                    Console.WriteLine("---> Seu número é maior !");
                    Console.WriteLine();
                }
                if(NumTentativa < num)
                {
                    Console.WriteLine("---> Seu número é menor !");
                    Console.WriteLine();
                }
                Console.WriteLine("---> Digite o número a ser comparado !!!");
                NumTentativa = Convert.ToInt32(Console.ReadLine());
                Tentativa++;
            }

            Console.WriteLine($"---> Você Acertou com {Tentativa} tentativas");
        }
    }
}
