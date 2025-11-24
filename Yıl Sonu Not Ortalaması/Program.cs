using System;

namespace Egzersiz4
{    


    class Program
    {

         
         /* Yıl Sonu Not Ortalaması */
         static void Main(string[] args)
         {  
            int vize1;
            int vize2;
            int final;
            double ort;

            Console.WriteLine("1.Vize notunu giriniz:");
            vize1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Vize notunu giriniz:");
            vize2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Final notunu giriniz:");
            final = Convert.ToInt32(Console.ReadLine());

            ort = (vize1 * 30/100) + (vize2 * 0.3) + (final * 0.4);

            Console.WriteLine("Yılsonu not ortalaması:" + ort);
                     
         }         

    }

}