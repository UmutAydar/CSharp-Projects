using System;

namespace P007_FaktöriyelHesaplama
{

    class Program
    {

         
         /* Klavyeden girilen bir sayının faktöriyelini hesaplama
            n! = n * (n-1) * (n-2) *...* 1
            4! = 4 * 3 * 2 * 1 = 24 
         */
         static void Main(string[] args)
         {
                   
           Console.WriteLine("Bir Sayı Giriniz:");          
           int n = Convert.ToInt32(Console.ReadLine());
           int f = 1;

           while(n > 1)
           {
               f = f*n;
               n = n-1;
             
           }
             
             Console.WriteLine("Girilen Sayının Faktöriyeli: " + f);

         }         

    }
}