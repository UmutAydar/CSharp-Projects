using System;

namespace Egzersiz3
{    


    class Program
    {

         
         /* Mutlak Değer Hesaplama */
         static void Main(string[] args)
         {   
               
            Console.WriteLine("Sayı giriniz:");
            int a = Convert.ToInt32(Console.ReadLine());

            if(a < 0)
            {
                a = a * (-1) ;
                
            }
            
                Console.WriteLine("Girilen sayının mutlak değeri : " + a);
                                                                  
         }         

    }

}