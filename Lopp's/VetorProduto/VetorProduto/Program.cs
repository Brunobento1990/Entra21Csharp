using System;

namespace VetorProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Prod1 = new int[5];
            int[] Prod2 = new int[5];
            int[] Prod3 = new int[5];
            for (int i = 0; i < Prod1.Length; i++)
            {
                Console.WriteLine("--> Insira o valor do produto no primeiro grupo");
                Prod1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < Prod2.Length; i++)
            {
                Console.WriteLine("--> Insira o valor do produto no segundo grupo");
                Prod2[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < Prod3.Length ; i++)
            {
                Prod3[i] = Prod1[i] * Prod2[i];
                Console.WriteLine("--> A mutiplicação dos prduto é : " + Prod3[i]);
            }
        }
    }
}
