using System;

namespace Egzersiz6
{    


    class Program
    {

         
         /* 1 ile 50 arasında tek ve dörde bülünen sayılar */
         static void Main(string[] args)
         {  
              
               
            for(int i = 1 ; i<50; i++)
            {
               if(i % 2 !=0 )
               {
                Console.WriteLine("Tek Sayılar :" + i);
               }
              
            }
            for(int a = 1 ; a<50; a++)
            {
                if(a % 4 ==0)
                {
                    Console.WriteLine("Dörde Bölünen Sayılar:" + a);
                }
            }
             
         }         

    }

}