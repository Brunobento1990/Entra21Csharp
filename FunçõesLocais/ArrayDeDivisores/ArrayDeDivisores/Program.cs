using System;

namespace ArrayDeDivisores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que receba um valor e usando uma função retorne todos os divisores entre 0 e o número
            Console.WriteLine("---> Digite o número a ser comparado os seus divisores !");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int[] Divisores = NumerosDivisor(n1);
            for(int i = 0; i < Divisores.Length; i++)
            {
                if (Divisores[i] != 0)
                {
                    Console.WriteLine($"---> Os divisores de {n1} são {Divisores[i]}");
                }
            }


        }
        static int[] NumerosDivisor(int n1)
        {
            int divisor,cont=1;
            int[] Divisores1 = new int[n1];
            int[] Divisores2 = new int[n1];
            for (int i = 0; i < Divisores1.Length; i++)
            {
                
                Divisores1[i] = i;
                 divisor = n1 %  cont;
                if (divisor == 0)
                {
                    Divisores2[i] = cont; 
                }
               
                cont++;
            }
            return Divisores2;
        }
    }
}
