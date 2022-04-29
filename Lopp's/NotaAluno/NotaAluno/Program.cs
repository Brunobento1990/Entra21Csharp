using System;

namespace NotaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nota = new int[2];
            int teste1 = nota[0];
            int testenotamaior = nota[0];
            for(int i = 0; i < nota.Length; i++)
            {
                Console.WriteLine("Digito a nota do aluno");
                nota[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            for(int i = 0; i < nota.Length; i++)
            {
                teste1 = teste1 + nota[i];
            }
            int media = teste1 / nota.Length;
           
            Console.WriteLine(media);
            
        }
    }
}
