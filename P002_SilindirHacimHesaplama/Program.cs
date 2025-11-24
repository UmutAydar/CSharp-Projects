using System;

namespace P002_SilindirHacimHesaplama
{

    class Program
    {

         
         /*Silindir hacim  hesaplama
         hacim =pi sayısı * yarıçapın karesi * yükseklik */
         static void Main(string[] args)
         {
           
            int  r;
            int  h;
            double pi = 3.14159; /* Ondalıklı sayılar için = float, double, decimal kullanılabilir. */ 

            Console.WriteLine("Silindirin yarıçapını girin:");
            r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Silindirin yüksekliğini girin:");
            h = Convert.ToInt32(Console.ReadLine());

            double v = pi * r * r * h;


           Console.WriteLine("Silindirin Hacmi: " + v );
           Console.WriteLine("Silindirin Hacmi:{0:N2} ", v ); /* Bu kısım {0:N2} gösterim şeklidir. Virgülden sonraki gösterilecek sayıyı belirler.*/
         }         

    }
}