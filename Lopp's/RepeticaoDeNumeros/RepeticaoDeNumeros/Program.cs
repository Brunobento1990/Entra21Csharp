using System;

namespace RepeticaoDeNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            // Faça um programa que receba o número de entradas e retornar se há numeros repitidos
            // e quantas vezes se repetiram

            int teste1;
    
            Console.WriteLine("---> Insira o tamanho do vetor");
            teste1 = Convert.ToInt32(Console.ReadLine());
            int[] cont = new int[teste1];
            int[] cont1 = new int[teste1];
            int[] cont2 = new int[teste1];
            for (int i = 0;i < cont.Length; i++)
            {
                Console.WriteLine("--> Insira os números a serem comparados");
                cont[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            for (int i = 0; i < cont.Length; i++)
            {
                cont1[i] = cont[i];

            }
            for(int i = 0; i < cont.Length; i++)
            {
                 for(int j = 0; j < cont1.Length; j++)
                {
                    if(cont[i] == cont1[j])
                    {
                        cont2[i]++;
                    }
                }
            }
            Console.WriteLine(" se repetiu " + cont.Length);
        }
    }
}
