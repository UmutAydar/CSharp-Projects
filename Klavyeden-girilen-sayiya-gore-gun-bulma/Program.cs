using System;

namespace Egzersiz10
{    


    class Program
    {

         
         /* Klavyeden girilen sayıya göre gün bulma */
         static void Main(string[] args)
         {
                int day;

            do
            {
                Console.WriteLine("Sayı giriniz:");
                day = Convert.ToInt32(Console.ReadLine());
                
                if(day == 1)
                {
                    Console.WriteLine("Pazartesi");
                }
                else if( day == 2)
                {
                    Console.WriteLine("Salı");
                }
                 else if( day == 3)
                {
                    Console.WriteLine("Çarşamba");
                } 
                else if( day == 4)
                {
                    Console.WriteLine("Perşembe");
                }
                 else if( day == 5)
                {
                    Console.WriteLine("Cuma");
                }
                  else if( day == 6)
                {
                    Console.WriteLine("Cumartesi");
                }
                else if( day == 7)
                {
                    Console.WriteLine("Pazar");
                }               
                else
                {
                   Console.WriteLine("Hatalı giriş");
                }

            }while(day<1 || day > 7);
                
         }         

    }

}