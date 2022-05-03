using System;

namespace LoopComparação
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0, contadorVetor = 0;
            Console.WriteLine("--> Insira o número que será o tamanho do Vetor ");
            int tamVetor = Convert.ToInt32(Console.ReadLine());

            int[] vetor1 = new int[tamVetor];
            int[] vetor2 = new int[tamVetor];
            int[] contarRepetidos = new int[tamVetor];
            int[] marcarRepetidos = new int[tamVetor];

            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.WriteLine("--> Insira os valores do vetor");
                vetor1[i] = Convert.ToInt32(Console.ReadLine());

                vetor2[i] = vetor1[i];
            }
            for (int i = 0; i < vetor1.Length; i++)
            {
                for (int j = 0; j < vetor1.Length; j++)
                {
                    if (i != j)
                    {
                        if (vetor1[i] == vetor2[j] && marcarRepetidos[j] ==0)
                        {
                            contarRepetidos[i]++;
                            marcarRepetidos[i] = 1;
                            marcarRepetidos[j] = -1;
                        }
                        //contadorVetor = vetor1[i];
                        //Console.WriteLine("--> O elemento  " + vetor3[i] + "  " + "se repetiu " + contador + " vezes !!!");
                        //contador++;
                        //contadorVetor++;
                    }
                }

            }
            for(int i = 0; i < contarRepetidos.Length; i++)
            {
                if (contarRepetidos[i] > 0 && marcarRepetidos[i] > 0)
                {
                    Console.WriteLine($"O elemento {vetor1[i]} na posição {i} repete {contarRepetidos[i]} vezes.");
                }
            }

            //Console.WriteLine("--> O elemento  " + contadorVetor + "  " + "se repetiu " + contador + " vezes !!!");
        }
    }
}
