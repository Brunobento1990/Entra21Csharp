using System;

namespace NotaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            // Faça um programa que receba 10 notas de alunos
            // Retorne a média, a maior nota, e a menor nota

            double[] nota = new double[10];
            double notaTot = nota[0];
            double notMaior = 0, notMenor = 10;
            int i = 0;
            
            while( i < nota.Length )
            {
                Console.WriteLine("Digito a nota do aluno");
                nota[i] = Convert.ToDouble(Console.ReadLine());
                notaTot = notaTot + nota[i];
                
                if (notMaior < nota[i])
                {
                    notMaior = nota[i];
                }
                if (notMenor > nota[i])
                {
                    notMenor = nota[i];
                }
                i++;
            }
            
            double media = notaTot / nota.Length;
            Console.WriteLine("---> A média do alunos é : " + media.ToString("f"));
            Console.WriteLine("---> A menor nota é : " + notMenor.ToString("f"));
            Console.WriteLine("---> A maior nota é : " + notMaior.ToString("f"));
        }
    }
}
