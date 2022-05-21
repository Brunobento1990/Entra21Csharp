using System;

namespace CalcularMMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---> Calcular Mínimo Multiplo Comum de 3 números inteiros <---");
            Console.WriteLine();
            Console.WriteLine("---> Insira o 1° número !");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---> Insira o 2° número !");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---> Insira o 3° número !");
            int n3 = Convert.ToInt32(Console.ReadLine());

        }
        static int[] CalcularMMC ( int n1,int n2,int n3)
        {

            int[] teste1 = new int[n1];
            int[] teste2 = new int[n2];
            int[] teste3 = new int[n3];
            for(int i = 0; i < teste1.Length; i++)
            {
                int result = n1 % i;
                if(result == 0)
                {
                    teste1[i] = i;
                }

            }
            for(int i = 0; i < teste2.Length; i++)
            {
                int result = n2 % i;
                if(result == 0)
                {
                    teste2[i] = i;
                }
            }
            for(int i = 0; i < teste3.Length; i++)
            {
                int result = n3 % i;
                if (result == 0)
                {
                    teste3[i] = i;
                }
            }
            return teste3;
        }
    }
}
