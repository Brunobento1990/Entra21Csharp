using System;

namespace AlunosReprovadosAprovados
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que receba 10 notas de alunos e com funções verifique se o aluno reprovou ou passou, média 7
            int[] teste = arrayNota();
            compararNotas(teste[]);
        }
        static int[] arrayNota()
        {
            int[] notas = new int[10];
            for(int i = 0;i < notas.Length; i++)
            {
                Console.WriteLine("---> Insira a nota do aluno !");
                notas[i] = Convert.ToInt32(Console.ReadLine());

            }
            return notas;
        }
        static int compararNotas(teste)
        {
            int[] teste = new int[10];
            bool aprov,reprov;
            int retorno;
            //int aprovado,reprovado;
            for(int i =0;i < teste.Length; i++)
            {
                aprov = teste[i] >= 7;
                reprov = teste[i] < 7;
            }
            retorno = teste[];
            return Console.WriteLine(retorno);

        }


    }
}
