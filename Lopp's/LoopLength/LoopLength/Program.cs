using System;

namespace LoopLength
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que receba um número indefinido de entradas
            //Calcule a média dos valores de todas as entradas

            double contador = 0, i , media, contadorEntrada = 0;
            
            Console.WriteLine("--> Digite um número !!! \n \n Para parar o programa digite um número negativo");
            i = Convert.ToDouble(Console.ReadLine());
            while (i > 0)
            {
                contadorEntrada = contadorEntrada + 1;
                contador = contador + i;
                Console.WriteLine("--> Digite um número !!! \n \n Para parar o programa digite um número negativo");
                i = Convert.ToDouble(Console.ReadLine());
                
            }
            media = contador / contadorEntrada;
            Console.WriteLine("A média da entrada é : " + media.ToString("f"));

            

            
            
            
        }
    }
}
