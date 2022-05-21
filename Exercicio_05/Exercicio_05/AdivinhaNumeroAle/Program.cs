using System;

namespace AdivinhaNumeroAle
{
    class Program
    {
        static void Main(string[] args)
        {
            Random NumCerto = new Random();
            int num = NumCerto.Next(1,10);
            Console.WriteLine("---> Digite o número a ser comparado !!!");
            int NumTentativa = Convert.ToInt32(Console.ReadLine());
            int FunctionJogo = JogoNume(num, NumTentativa);
            Console.WriteLine($"---> O número certo é {FunctionJogo}");
        }
        static int JogoNume(int num, int NumTentativa)
        {
            int Tentativa = 1;
            while (num != NumTentativa)
            {
                
                if (NumTentativa > num)
                {
                    Console.WriteLine("---> Seu número é maior que o número aleatório !");
                    Console.WriteLine();
                }
                if (NumTentativa < num)
                {
                    Console.WriteLine("---> Seu número é menor que o número aleatório !");
                    Console.WriteLine();
                }
                Console.WriteLine("---> Digite o número a ser comparado !!!");
                NumTentativa = Convert.ToInt32(Console.ReadLine());
                Tentativa++;
            }

            Console.WriteLine($"---> Você Acertou com {Tentativa} tentativas");
            Console.WriteLine();
            return NumTentativa;
        }
    }
}
