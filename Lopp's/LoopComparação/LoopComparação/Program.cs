using System;

namespace LoopComparação
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador =0,contadorVetor=1;
            Console.WriteLine("--> Insira o número que será o tamanho do Vetor ");
            int tamVetor = Convert.ToInt32(Console.ReadLine());

            int[] vetor1 = new int[tamVetor];
            int[] vetor2 = new int[tamVetor];

            for(int i = 0; i < vetor1.Length; i++)
            {
                Console.WriteLine("--> Insira os valores do vetor");
                vetor1[i] = Convert.ToInt32(Console.ReadLine());

                vetor2[i] = vetor1[i];
            }
            for(int i = 0; i < vetor1.Length; i++)
            {
                for(int j = i+1; j < vetor1.Length; j++)
                {
                    if (vetor1[i] == vetor2[j])
                    {
                        //contadorVetor = vetor1[i];
                       // Console.WriteLine("--> O elemento "+ vetor1[i] +"  "+"se repetiu " + contador);
                        contador++;
                    }
                }
               
            }
            Console.WriteLine("--> O elemento  " + contadorVetor +"  " + "se repetiu " + contador);
        }
    }
}
