using System;

namespace Egzersiz6
{    


    class Program
    {

         
         /* 1 ile 100 arasında sayı girene kadar */
         static void Main(string[] args)
         {  
            int a;
              
            do
            {

               Console.WriteLine("Sayı giriniz:");
               a = Convert.ToInt32(Console.ReadLine());

               if( a < 1)
               {
                Console.WriteLine( "Girdiğiniz sayı 1'den küçük. Tekrar deneyin.");
               }
               else if (a>100)
               {
                Console.WriteLine( "Girdiğiniz sayı 100'den büyük. Tekrar deneyin.");
               }
               else
               {
                Console.WriteLine("Teşekkürler! 1 ile 100 arasında bir sayı girdiniz.");
               }
            
            } while(a<1 || a>100);
                          
         }         

    }

}