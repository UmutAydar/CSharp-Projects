using System;

namespace P001_AlanHesabı
{    


    class Program
    {

         
         /*Dikdörtgende alan hesaplama*/
         static void Main(string[] args)
         {
           
            int  a;
            int  b;

            Console.WriteLine("Birinci Sayıyı girin:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci Sayıyı girin:");
            b = Convert.ToInt32(Console.ReadLine());
           
           
            int c = a * b;

           Console.WriteLine("Alan: " + c );

         }         

    }

}