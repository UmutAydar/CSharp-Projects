using System;

namespace P004_GirilenİkiSayıKarşılaştırma
{

    class Program
    {

         
         /* Klavyeden girilen iki sayıyı karşılaştırma(büyük,küçük,eşit) */
         static void Main(string[] args)
         {
           int a ;
           int b;

           Console.WriteLine("Birinci Sayıyı girin: ");
           a = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("İkinci Sayıyı girin: ");
           b = Convert.ToInt32(Console.ReadLine());

           /* Birinci Yöntem */

           if(a > b)
           {
                 Console.WriteLine("{0} sayısı {1} sayısından büyüktür. " , a,b);
           }
           else 
           {

              if( b > a )
              {
               
                 Console.WriteLine("{0} sayısı {1} sayısından büyüktür. " , b,a);
              
              }

              else
              {
                 Console.WriteLine("İki Sayı Birbirine Eşittir.");
              } 

           }

              /*İkinci Yöntem*/

          if( a > b )

          {
            Console.WriteLine("{0} sayısı {1} sayısından büyüktür. " , a,b);
          }

          else if ( b > a )
          {
            Console.WriteLine("{0} sayısı {1} sayısından büyüktür. " , b,a);
          }

          else
          {
            Console.WriteLine("İki Sayı Birbirine Eşittir");
          }

         }

           

                  

    }
}