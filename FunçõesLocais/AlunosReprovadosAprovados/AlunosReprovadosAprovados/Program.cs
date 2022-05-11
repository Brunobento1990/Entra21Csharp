using System;

namespace AlunosReprovadosAprovados
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que receba 10 notas de alunos e com funções verifique se o aluno foi aprovado ou reprovado, média 7
            //Retorne um array do tipo bool
            
            int[] Notas = ArrayNota();
            bool[] ArrayBollNotas = VerificarNotas(Notas);
            
            for(int i = 0; i < ArrayBollNotas.Length; i++)
            {
                Console.WriteLine(ArrayBollNotas[i]);
            }
        }
        static int[] ArrayNota()
        {
            int[] notas = new int[10];
            for(int i = 0;i < notas.Length; i++)
            {
                Console.WriteLine("---> Insira a nota do aluno !");
                notas[i] = Convert.ToInt32(Console.ReadLine());

            }
            return notas;
        }
        static bool[] VerificarNotas(int[]Notas)
        {
            bool[] ArrayBoll = new bool[10];
            bool aprov;
            for(int i =0;i < Notas.Length; i++)
            {
                int nota = Notas[i];
                aprov = nota >= 7;
                ArrayBoll[i] = aprov;
            }
            return ArrayBoll;

        }
    }
}
