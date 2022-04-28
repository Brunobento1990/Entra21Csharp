using System;

namespace LerConsoante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a letra a ser indentificado como consoante ou vogal");
            string letra = Console.ReadLine();
            if(letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
            {
                Console.WriteLine("Sua letra é uma vogal");
            }
            else if(letra == "A" || letra == "E" || letra == "I" || letra == "O" || letra == "U")
            {
                Console.WriteLine("Sua letra é uma vogal");
            }
            else if(letra.Length > 1)
            {
                Console.WriteLine("Você inseriu mais de uma letra");
            }
            else
            {
                Console.WriteLine("Sua letra é uma consoante");
            }
        }
    }
}
