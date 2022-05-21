using System;

namespace ArrayOrdemInversa
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ArrayAuxiliar = PreencherArray();
            int[] ArrayInverso = InverterArray(ArrayAuxiliar);
            for(int i = 0; i < ArrayInverso.Length; i++)
            {
                Console.WriteLine($"---> Array inverso {ArrayInverso[i]}");
            }
        }
        static int[] PreencherArray()
        {
            int[] Array10 = new int[10];
            for(int i = 0; i < Array10.Length; i++)
            {
                Console.WriteLine("---> Insira um número para preencher o array !");
                Array10[i] = Convert.ToInt32(Console.ReadLine());
            }
            return Array10;
        }

        static int[] InverterArray(int[] Array10)
        {
            int j = 9;
            int[] ArrayInverso = new int[10];
            for(int i = 0;i<ArrayInverso.Length;i++)
            {
                
                ArrayInverso[j] = Array10[i];
                j--;
            }
            return ArrayInverso;
        }
    }
}
