using System;

namespace People10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Faça um programa que receba o nome de 10 pessoas e retorne os nomes
            string[] pessoas = new string[10];
            
            for(int i = 0; i < pessoas.Length; i++)
            {
                Console.WriteLine("Digite o nome de uma pessoa");
                pessoas[i] = Console.ReadLine();
            }
            for (int i = 0; i < pessoas.Length; i++)
            {
                Console.WriteLine("Nome : " + pessoas[i]);
            }
        }
    }
}
