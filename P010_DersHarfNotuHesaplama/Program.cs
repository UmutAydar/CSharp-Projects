using System;

namespace P009_DerstenAlınanEnİyiNotBulma
{

    class Program
    {

         
         /* Bir dersten alınan en iyi notu bulma */
         static void Main(string[] args)
         {  
            string[] grades = new string[15]{"A","F","C","A","B","B","D","F","C","C","C","B","D","F","A"};
            int[] statics = new int[5]; // 0: A alan öğrenci sayısı, 1: B alan öğrenci sayısı,...... 4: F alan öğrenci sayısı
             
            for(int i = 0; i < 15; i++)
            { 
                
                switch(grades[i])
                {
                    case "A":
                    case "a":
                     statics[0] = statics[0] + 1;
                     break;
                    case "B":
                    case "b":
                     statics[1] += 1;
                     break;
                    case "C":
                    case "c":
                     statics[2]++;
                     break;
                    case "D":
                    case "d":
                     statics[3]++;
                     break;
                    case "F":
                    case "f":
                     statics[4]++;
                     break;

                }
            }
                

              Console.WriteLine("Öğrencilerin sırasıyla harf notu dağılımı:");
              for(int i = 0; i < 5; i++)
               {
                 Console.WriteLine(statics[i]);
               }
              
                 

    

        }        
    }
}        