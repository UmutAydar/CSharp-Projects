namespace AsalSayiBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz:");
            int number = Convert.ToInt32(Console.ReadLine());

            int total;
            int toplam = 0;


            for (int i = 1; i <= number; i++)
            {

                total = number % i;
                
                if (total == 0)
                {
                    toplam += 1;
                }
               
            }

            if (toplam == 2)
            { 
                Console.WriteLine("{0} sayısı asal sayıdır.", number);
            }
            else
            {
                Console.WriteLine("{0} sayısı asal değildir.", number);
            }


        }
    }
}
