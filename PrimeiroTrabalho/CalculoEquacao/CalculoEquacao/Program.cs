using System;

namespace CalculoEquacao
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b,c,b2,result4ac,delta;
            Console.WriteLine("Insira o valor de A :")
            a = Convert.ToDouble(Console.ReadLine());
         
            Console.WriteLine("Informe o valor de B :")
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o valor de C :")
            c = Convert.ToDouble(Console.ReadLine());
            b2 = b * b;
            result4ac = 4 * a * c;
            delta = b2 + result4ac;
            //double rai = Math.Sqrt(9)

            if(a == 0)
            {
                Console.WriteLine("O valor de A não pode ser igual a zero");
            }

            if(delta < 0)
            {
                Console.WriteLine("O valor de Delta é negativo e não haverá raizes" + rai);
            }


        }
    }
}
