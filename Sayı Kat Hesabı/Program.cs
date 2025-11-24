using System;

namespace Egzersiz1
{    


    class Program
    {

         
         /* Katı Olup Olmadığını Hesaplama */
         static void Main(string[] args)
         {   
           
            int a ;
            int b;
        

            Console.WriteLine("1.Sayıyı Giriniz:");
            a = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("2.Sayıyı Giriniz:");
            b = Convert.ToInt32(Console.ReadLine());
            
            if( a % b == 0)
            {
              Console.WriteLine(a + " sayısı " + b + " sayısının tam katıdır.");
            }
            else
            {
                Console.WriteLine(a + " sayısı " + b + " sayısının tam kat değildir.");
            }

                    





         }         

    }

}