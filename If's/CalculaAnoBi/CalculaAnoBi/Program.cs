using System;

namespace CalculaAnoBi
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a4 = 4,a400 = 400,a100 = 100;
            Console.WriteLine("Insira o ano a ser verificado se é Bissexto");
            double ano = Convert.ToDouble(Console.ReadLine());
            
             double resto = ano %4;
             double resto1 = ano %400;
             double resto2 = ano %100;
            if ((resto1 == 0) || resto == 0 && resto2 != 0)
            {
                Console.WriteLine(ano + "  é Bissexto  " + resto + " " + resto1 + " " + resto2);
            }
            else
            {
                Console.WriteLine(ano + "  não é Bissexto  " + resto +" "+ resto1+" " + resto2);
            }
        }
    }
}
