using System;

namespace Egzersiz8
{    


    class Program
    {

         
         /* Dizideki en küçük elemanı bulma */
         static void Main(string[] args)
         {  
           int[] items = new int[] {8, 7, 9, 17, 3, -5, -1, 6, 20, 13};
           int smallestNumber = items[0];
 
           for (int i = 0; i < 10; i++)
            {
           
              if (smallestNumber > items[i])
              {
                smallestNumber = items[i];
              }
            }
 
           Console.WriteLine("Dizideki en küçük eleman: " + smallestNumber);


         }         

    }

}