using System;

namespace P009_DerstenAlınanEnİyiNotBulma
{

    class Program
    {

         
         /* Bir dersten alınan en iyi notu bulma */
         static void Main(string[] args)
         { /* 
            int grade1 = 90;
            int grade2 = 55;
            int grade3 = 50;

            if(grade1 > grade2)
            {
                if(grade1 > grade3)
                {
                    Console.WriteLine("En iyi not : " + grade1);

                }
                else
                {
                    Console.WriteLine("En iyi not: " + grade3);
                }

            }
            else
            {
                if( grade2 > grade3)
                {
                    Console.WriteLine("En iyi not : " + grade2);
                }
                else
                {
                    Console.WriteLine("En iyi not: " + grade3);
                }
            } */
       
               
           /* Dizi kullanarak çözüm */

           int[] grades = new int[3];
           grades[0] = 90;
           grades[1] = 85;
           grades[2] = 60;
           int maxGrade = 0;
           
           for(int i = 0; i <=2; i++)
           {
            
             if(grades[i] > maxGrade)
             {
                maxGrade = grades[i];

             }

           }
         
           Console.WriteLine("En iyi not: " + maxGrade);
        

        }         

    }
}