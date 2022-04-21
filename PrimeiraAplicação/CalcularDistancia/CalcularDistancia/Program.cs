using System;

namespace CalcularDistancia
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calcucalar distancia

            double Lat1, Alt1, Lat2, Alt2, r1,r2,tot1,tot2,r11,r22;

            Console.WriteLine("Digite a Latitude");
            Alt1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a Longitude");
            Lat1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a segunda Latitude");
            Lat2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a segunda Longitude");
            Alt2 = Convert.ToDouble(Console.ReadLine());
            r1 = Alt1 - Alt2;
            r2 = Lat1 - Lat2;
            r11 = r1 * r1;
            r22 = r2 * r2;

            tot1 = r11 + r22;
            tot2 = tot1 * tot1;

            Console.WriteLine("A distância é " + tot2 + " Km");

        }
    }
}
