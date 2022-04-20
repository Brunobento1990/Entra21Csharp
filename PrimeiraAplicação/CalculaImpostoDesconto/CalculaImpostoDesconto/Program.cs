using System;

namespace CalculaImpostoDesconto
{
    class Program
    {
        static void Main(string[] args)
        {
           
           //Exercício de produto

           double valorProd, valortot, porcentImp, valorDesc;
            Console.WriteLine("Qual o valor do produto");
            double prod = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a porcentagem do desconto");
            double desc = Convert.ToDouble(Console.ReadLine());

            if (prod <= 100)
            {
                porcentImp = (prod * 5) / 100; //Porcentagem de imposto

                valorDesc = (prod * desc) / 100; //Valor do produto com desconto
                valorProd = prod - valorDesc;
                valortot = valorProd + porcentImp;
                Console.WriteLine("Valor do produto com desconto é " + valorProd + " e o valor com alíquota de 5% é " + valortot);
            }
            if (prod > 100 && prod <= 300)
            {
                porcentImp = (prod * 15) / 100; //Porcentagem de imposto

                valorDesc = (prod * desc) / 100; //Valor do produto com desconto
                valorProd = prod - valorDesc;
                valortot = valorProd + porcentImp;
                Console.WriteLine("Valor do produto com desconto é " + valorProd + " e o valor com alíquota de 15% é " + valortot);

            }
            if (prod > 300 && prod <= 1000)
            {
                porcentImp = (prod * 25) / 100; //Porcentagem de imposto

                valorDesc = (prod * desc) / 100; //Valor do produto com desconto
                valorProd = prod - valorDesc;
                valortot = valorProd + porcentImp;
                Console.WriteLine("Valor do produto com desconto é " + valorProd + " e o valor com alíquota de 25% é " + valortot);
            }


        }
    }
}
