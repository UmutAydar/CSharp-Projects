using System;

namespace Egzersiz5
{    


    class Program
    {

         
         /* 10 adet sayının ortalaması */
         static void Main(string[] args)
         {  
            
            int sayi;
            int toplam = 0;
            int sayac = 0;
            double ort = 0;
            do
            {
                Console.WriteLine("Bir sayı giriniz:");
                sayi = Convert.ToInt32(Console.ReadLine());
                
                toplam += sayi;
                sayac += 1;
                
            }while(sayac < 10 );

                ort = toplam / sayac;
                
                Console.WriteLine("Girilen Sayıların Ortalaması :" + ort);
                              
         }         

    }

}