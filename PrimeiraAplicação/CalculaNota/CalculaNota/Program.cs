using System;

namespace CalculaNota
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calcula nota

            Console.WriteLine("Digite a primeira nota");
            double not1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota");
            double not2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota");
            double not3 = Convert.ToDouble(Console.ReadLine());

            double media = (not1 + not2 + not3) / 3;

            if (not1 >= not2 && not1 > not3 && not3 < not2)
            {
                Console.WriteLine("Sua maior nota é " + not1 + " sua menor nota é " + not3 + " e sua média é " + media);
            }
            if (not2 >= not3 && not2 > not1 && not1 < not3)
            {
                Console.WriteLine("Sua maior nota é " + not2 + " sua menor nota é " + not1 + " e sua média é " + media);
            }
            if (not3 >= not1 && not3 > not2 && not2 < not1)
            {
                Console.WriteLine("Sua maior nota é " + not3 + " sua menor nota é " + not2 + " e sua média é " + media);
            }
            


        }
    }
}
