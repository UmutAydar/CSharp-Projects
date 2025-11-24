using System;

namespace Egzersiz9
{    


    class Program
    {

         
         /* Faiz Hesaplaması  */
         static void Main(string[] args)
         {  

            double capital = 10000;
            double interestRate = 0.1;
            int year = 5;
              

           for (int i = 1; i <= year; i++)
           { 
            capital = capital * (1 + interestRate); 
            Console.WriteLine(i + ". yıl sonunda toplam anapara: {0:N2}", capital);
            
           }

         }         

    }

}