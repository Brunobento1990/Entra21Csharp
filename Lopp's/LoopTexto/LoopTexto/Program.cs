using System;

namespace LoopTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Faça um programa que receba 10 entradas de textos e retorne todos ele intercalados
            // do caractere " -ou- "
            string[] text = new string[10];
            for(int i = 0; i < text.Length; i++)
            {
                Console.WriteLine("--> Digite o texto");
                text[i] = Console.ReadLine();
            }
            Console.WriteLine(text[0] + "-ou-" + text[1]+ "-ou-" + text[2] + "-ou-" + text[3] + text[4] + "-ou-" + text[5] + text[2] + "-ou-" + text[3]);
        }
    }
}
