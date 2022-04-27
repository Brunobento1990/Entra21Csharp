using System;

namespace CalcularSalário
{
    class Program
    {
        static void Main(string[] args)
        {
            double salar1, aliquota, salarTot, salarDolar, salarEuro;
            Console.WriteLine("Qual seu salário?");
            salar1 = Convert.ToDouble(Console.ReadLine());


            if(salar1 <= 1200)
            {
                aliquota = (salar1 * 20) / 100;
                salarTot = salar1 + aliquota;
                salarDolar = salarTot / 4.70;
                salarEuro = salarTot / 5.20;
                Console.WriteLine("Seu aumento é de 20%, seu salário total é " + salarTot + " em dólar " + salarDolar + " em Euro " + salarEuro);
            }
            if(salar1 > 1200 && salar1 <= 2000)
            {
                aliquota = (salar1 * 13) / 100;
                salarTot = salar1 + aliquota;
                salarDolar = salarTot / 4.70;
                salarEuro = salarTot / 5.20;
                Console.WriteLine("Seu aumento é de 13%, seu salário total é " + salarTot + " em dólar " + salarDolar + " em Euro " + salarEuro);
            }
            if(salar1 > 2000 && salar1 <= 2500)
            {
                aliquota = (salar1 * 10) / 100;
                salarTot = salar1 + aliquota;
                salarDolar = salarTot / 4.70;
                salarEuro = salarTot / 5.20;
                Console.WriteLine("Seu aumento é de 10% ,seu salário total é " + salarTot + " em Dólar " + salarDolar + " em Euro " + salarEuro);
            }
            if(salar1 > 2500)
            {
                aliquota = (salar1 * 5) / 100;
                salarTot = salar1 + aliquota;
                salarDolar = salarTot / 4.70;
                salarEuro = salarTot / 5.20;
                Console.WriteLine("Seu aumento é de 5%, seu salário total é " + salarTot + " em Dólar " + salarDolar + " em Euro " + salarEuro);
            }
        }
    }
}
