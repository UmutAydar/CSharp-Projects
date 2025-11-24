using System;

namespace IkinciDereceKokBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double diskriminant, kok1, kok2;

            Console.Write("x^2 nin katsayısını giriniz:");
            a=Convert.ToInt32(Console.ReadLine());

            Console.Write("x'in başkatsayısını giriniz:");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("sabit sayıyı giriniz:");
            c = Convert.ToInt32(Console.ReadLine());


            diskriminant = Math.Sqrt((b * b) - 4*(a * c));

            if (diskriminant > 0)
            {
                kok1 = (-b + diskriminant) / (2 * a);

                kok2 = (-b - diskriminant) / (2 * a);

                Console.WriteLine("Denkleminiz {0}x^2+{1}x+{2}'dir.", a, b, c);
                Console.WriteLine("Denkleminiz kökleri:");
                Console.WriteLine("1.Kök:" + kok1);
                Console.WriteLine("2.Kök:" + kok2);
            }
            else if (diskriminant == 0) 
            {
                double kok = -b / (2 * a);
                Console.WriteLine($"iki kök ve eşittir ve {kok} değerindedir");
            }
            else
            {
                Console.WriteLine("Diskriminant negatif. Gerçek kökler yok.");
            }

        }
    }
}
