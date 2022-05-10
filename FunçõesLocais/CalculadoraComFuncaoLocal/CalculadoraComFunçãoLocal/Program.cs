using System;

namespace CalculadoraComFunçãoLocal
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            double n1, n2,result;
            while (i > 0)
            {
                Console.WriteLine("---> MENU \n\n ---> Escolha a operação ! \n\n ---> 1 Adição \n\n ---> 2 Subtração \n\n ---> 3 multiplicação \n\n ---> 4 Divisão \n\n ---> 0 Sair ");
                i = Convert.ToInt32(Console.ReadLine());
                if(i == 1)
                {
                    Console.WriteLine("---> Digite o primeiro número !");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("---> Digite o segundo número !");
                    n2 = Convert.ToDouble(Console.ReadLine());
                    result = Soma(n1, n2);
                    Console.WriteLine("A soma é : "+result);
                }
                if(i == 2)
                {
                    Console.WriteLine("---> Digite o primeiro número !");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("---> Digite o segundo número !");
                    n2 = Convert.ToDouble(Console.ReadLine());
                    result = Subtrair(n1, n2);
                    Console.WriteLine("A subtração é : "+result);
                }
                if (i == 3)
                {
                    Console.WriteLine("---> Digite o primeiro número !");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("---> Digite o segundo número !");
                    n2 = Convert.ToDouble(Console.ReadLine());
                    result = Multiplicar(n1, n2);
                    Console.WriteLine("A multiplicação é : "+result);
                }
                if (i == 4)
                {
                    Console.WriteLine("---> Digite o primeiro número !");
                    n1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("---> Digite o segundo número !");
                    n2 = Convert.ToDouble(Console.ReadLine());
                    if (n2 <= 0)
                    {
                        Console.WriteLine("Não é possível dividir um número por zero !");
                    }
                    else
                    {
                        result = Dividir(n1, n2);
                        Console.WriteLine("A divisão é : " + result);
                    }
                   
                }


            }
        }
        static double Soma(double n1,double n2)
        {
            return n1 + n2;
        }
        static double Subtrair(double n1, double n2)
        {
            return n1 - n2;
        }
        static double Multiplicar(double n1, double n2)
        {
            return n1 * n2;
        }
        static double Dividir(double n1, double n2)
        {
            return n1 / n2;
        }
    }
}
