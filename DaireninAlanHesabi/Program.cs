using System;

namespace Egzersiz1
{    


    class Program
    {

         
         /* Dairenin Alan Hesabı */
         static void Main(string[] args)
         {   
            double pi = 3.14 ;

            Console.WriteLine("Yarıçapı giriniz:");
            int r = Convert.ToInt32(Console.ReadLine());
            double alan = pi * r * r ;
            Console.WriteLine("Dairenin Alanı:{0:N4}" , alan);
         }         

    }

}