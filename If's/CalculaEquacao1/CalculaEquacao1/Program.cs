using System;

namespace CalculaEquacao1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, b2, result4ac, delta;
            Console.WriteLine("Insira o valor de A :");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o valor de B :");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o valor de C :");
            c = Convert.ToDouble(Console.ReadLine());
            delta = (b * b) - (4 * a * c);
            double raiz = Math.Sqrt(delta);
            //Console.WriteLine(delta + "  " + rai);


            if (a == 0)
            {
                Console.WriteLine("O valor de A não pode ser igual a zero");
                return;
            }
            if(delta < 0)
            {
                Console.WriteLine("Valor de Delta é menor que zero e não raiz real");
            }
            if(delta == 0)
            {
                double x1 = (-b - raiz) / (2 * a);
                Console.WriteLine("O valor de Delta calculado é igual a zero, e só há uma raiz igual há : " + x1);
            }
            if(delta > 0)
            {
                double x1 = (-b - raiz) / (2 * a);
                double x2 = (-b + raiz) / (2 * a);
                Console.WriteLine("Os valores são : " + x1 + " " + x2);
            }

        }
    }
}
