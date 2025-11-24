using System;

namespace P003_İkiSatyıdanBüyükOlanıBulma
{

    class Program
    {

         
         /* Klavyeden girilen iki sayıdan büyük olanını bulma */
         static void Main(string[] args)
         {
           int a ;
           int b;

           Console.WriteLine("Birinci Sayıyı girin: ");
           a = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("İkinci Sayıyı girin: ");
           b = Convert.ToInt32(Console.ReadLine());

           if(a > b)
           {
                 Console.WriteLine("İki Sayıdan Büyük Olanı: " + a);
           }
           else /* a ve b eşit olabilir, b a'dan büyük olabilir */
           {
                 Console.WriteLine("İki Sayıdan Büyük Olan: " + b);             
           }

         }         

    }
}