using System;

namespace ArrayComFuncao
{
    class Program
    {
        static void Main(string[] args)
        {
           //Escreva um programa  que o usuario peencha um array de 10 posições utilizando função ou procedimento
           //Mostre o maior número 
           int NumMaior = ArrayTeste();
           Console.WriteLine("---> O maior número do array é :"+NumMaior);
        }
        static int ArrayTeste()
        {
            int[] Array10 = new int[10];
            int NumMaior = 1;
            for (int i = 0; i < Array10.Length; i++)
            {

                Console.WriteLine("---> Insira os valores do array !");
                Array10[i] = Convert.ToInt32(Console.ReadLine());
                if (Array10[i] > NumMaior)
                {
                    NumMaior = Array10[i];
                }
            }
            return NumMaior;
        }
    }
}
