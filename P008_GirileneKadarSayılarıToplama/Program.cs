using System;

namespace P008_GirileneKadarSayılarıToplama
{

    class Program
    {

         
         /*Klavyeden -1 girilene kadar girilen sayıların toplamını bulan uygulama */
         static void Main(string[] args)
         {
            int number;
            int sum = 0;

            do
            {
                Console.WriteLine("Bir sayı giriniz: ");
                number = Convert.ToInt32(Console.ReadLine());

                if(number != -1)
                {
                sum += number;
                }
                
            }while(number != -1);

            Console.WriteLine("Girilen sayıların toplamı: " + sum);
    

          
         }         

    }
}