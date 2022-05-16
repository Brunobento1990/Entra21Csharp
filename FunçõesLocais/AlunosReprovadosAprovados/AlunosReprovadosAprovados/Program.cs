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
            EscreverNotas(Notas, ArrayBollNotas);
           
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
                //int nota = Notas[i];
                aprov = Notas[i] >= 7;
                ArrayBoll[i] = aprov;
            }
            return ArrayBoll;

        }
        static void EscreverNotas(int[] nota, bool[] aprovado)
        {

            for(int i = 0; i < nota.Length; i++)
            {
                //Console.WriteLine($"Nota : {nota[i]} : {aprovado[i]}");
                if (aprovado[i] == true)
                {
                    Console.WriteLine($"Nota : {nota[i]} : Aprovado");
                }
                else
                {
                    Console.WriteLine($"Nota : {nota[i]} : Reprovado");
                }
            }
            
        }
    }
}
