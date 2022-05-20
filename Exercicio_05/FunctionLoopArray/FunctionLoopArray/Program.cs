using System;

namespace FunctionLoopArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] NotaSala = ArrayNotas();
            double[] SalaMediaMenor = NotaSalaTot(NotaSala);
            double MediaSala = Math.Round(SalaMediaMenor[1],2), MenorNotaSala = Math.Round(SalaMediaMenor[0],2), MaiorNotaSala = Math.Round(SalaMediaMenor[2],2);
            Console.WriteLine($" ---> A média da sala é {MediaSala} e a nota menor da sala é {MenorNotaSala} e a nota maior é {MaiorNotaSala}");
          
        }
        static double[] ArrayNotas()
        {
            double[] Aluno = new double[10];
            double[] Aluno1 = new double[10];
            double[] Aluno2 = new double[10];
            double[] NotaSala = new double[30];
            double Nota,Contador = 1,Contador1 = 1, NotaMenor, Media, Tot,NotaMaior;
            int P = 0;
            for (int i = 0; i < Aluno.Length; i++)
            {

                Console.WriteLine($"---> Insira a nota do {Contador} ° aluno !");
                Nota = Convert.ToDouble(Console.ReadLine());
                Aluno[i] = Nota;
                NotaSala[P] = Nota;
                P++;
                Console.WriteLine($"---> Insira a nota do {Contador} ° aluno !");
                Nota = Convert.ToDouble(Console.ReadLine());
                Aluno1[i] = Nota;
                NotaSala[P] = Nota;
                P++;
                Console.WriteLine($"---> Insira a nota do {Contador} ° aluno !");
                Nota = Convert.ToDouble(Console.ReadLine());
                Aluno2[i] = Nota;
                NotaSala[P] = Nota;
                P++;
                Contador++;
            }
            for (int i = 0; i < Aluno.Length; i++)
            {
                NotaMenor = 10;

                if (NotaMenor > Aluno[i])
                {
                    NotaMenor = Aluno[i];
                }
                if (NotaMenor > Aluno1[i])
                {
                    NotaMenor = Aluno1[i];
                }
                if (NotaMenor > Aluno2[i])
                {
                    NotaMenor = Aluno2[i];
                }
                NotaMaior = 0;

                if (NotaMaior < Aluno[i])
                {
                    NotaMaior = Aluno[i];
                }
                if (NotaMaior < Aluno1[i])
                {
                    NotaMaior = Aluno1[i];
                }
                if (NotaMaior < Aluno2[i])
                {
                    NotaMaior = Aluno2[i];
                }

                //NotaMenor = Aluno[i];
                Tot = Aluno1[i] + Aluno[i] + Aluno2[i];
                Media = (Tot - NotaMenor) / 2;
                Console.WriteLine($"---> A Menor nota do aluno {Contador1} é {NotaMenor} ,a maior é {NotaMaior} e a média é {Media}");
                Console.WriteLine();
                Contador1++;
            }
            
            
            return NotaSala;
        }
        static double[] NotaSalaTot(double[] NotaSala)
        {
            double[] NotaSalaTot = new double[30];
            double[] NotaSalaMedia = new double[3];
            double NotaMenor = 10,Notas = 0,NotaMaior = 0;
            for (int i = 0; i < NotaSalaTot.Length; i++)
            {
                NotaSalaTot[i] = NotaSala[i];
                if (NotaMenor > NotaSalaTot[i])
                {
                    NotaMenor = NotaSalaTot[i];
                    NotaSalaMedia[0] = NotaMenor;
                }
                if (NotaMaior < NotaSalaTot[i])
                {
                    NotaMaior = NotaSalaTot[i];
                    NotaSalaMedia[2] = NotaMaior;
                }

                Notas += NotaSalaTot[i];
            }
            NotaSalaMedia[1] = Notas / NotaSalaTot.Length;
            return NotaSalaMedia;
        }
       
       
    }
}
