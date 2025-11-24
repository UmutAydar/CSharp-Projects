using System;

namespace P005_TekVeÇiftBulma
{

    class Program
    {

         
         /* Klavyeden girilen sayının tek veya çift olduğunu bulan uygulama */
         static void Main(string[] args)
         {
                   
           Console.WriteLine("Bir Sayı Giriniz:");          
           int number = Convert.ToInt32(Console.ReadLine());
           string result;
           
           if(number % 2 == 0 )
           {
              result = "Çiftir";
           }
          else
          {
             result = "Tektir";
          }

          Console.WriteLine("Girilen sayi:" + result);

         }         

    }
}