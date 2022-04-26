using System;

namespace CalcularTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double lado1, lado2, lado3,calcTria1,calcTri2,calcTri3;
            Console.WriteLine("Para calcular um triangulo, é preciso 3 lados, informe os valores conforme a sequência");
            Console.WriteLine("______________________________________________________________________________________");
            Console.WriteLine("Informe a medida do primeiro lado");
            lado1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a medida do segundo lado");
            lado2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a media do terceiro lado");
            lado3 = Convert.ToDouble(Console.ReadLine());
            calcTria1 = lado1 + lado2;
            calcTri2 = lado1 + lado3;
            calcTri3 = lado2 + lado3;
            if(calcTria1 > lado3 || calcTri2 > lado2 || calcTri3 > lado1)
            {
                Console.WriteLine("Seu triângulo é um :");
            }
            if(lado1 == lado2 && lado1 == lado3)
            {
                Console.WriteLine("Equilátero");
            }
            if(lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                Console.WriteLine("Isósceles");
            }
            if(lado1 != lado2 && lado3 != lado2)
            {
                Console.WriteLine("Escaleno");
            }

            
        }
    }
}
