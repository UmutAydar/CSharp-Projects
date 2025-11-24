using System;

namespace P006_SayınınOndanKüçükVeTekOlma
{

    class Program
    {

         
         /* Klavyeden girilen sayının 10 'dan küçük ve tek olup olduğunu bulan uygulama */
         static void Main(string[] args)
         {
                   
           Console.WriteLine("Bir Sayı Giriniz:");          
           int a = Convert.ToInt32(Console.ReadLine());
           
           
            /*
            && --> Ve Kontrolü yapar.
            || --> Veya Kontrolü yapar.(İşareti yapmak için AltGr+<> tuşuna bas.)  
            */

           if(a < 10 && a % 2 == 1 )
           {
              Console.WriteLine("Sayı  10' dan küçüktür ve tektir.");
           }
          else
          {
             Console.WriteLine("Sayı 10'dan büyüktür veya çifttir..");
          }

         

         }         

    }
}