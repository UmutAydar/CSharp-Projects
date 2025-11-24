namespace AyTespiti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hangi Ayı öğrenmek istiyorsunuz: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number == 1)
            {
                Console.WriteLine("Ocak");
            }
            else if (number == 2)
            {
                Console.WriteLine("Şubat");
            }
            else if (number == 3)
            {
                Console.WriteLine("Mart");
            }
            else if (number == 4)
            {
                Console.WriteLine("Nisan");
            }
            else if (number == 5)
            {
                Console.WriteLine("Mayıs");
            }
            else if (number == 6)
            {
                Console.WriteLine("Haziran");
            }
            else if (number == 7)
            {
                Console.WriteLine("Temmuz");
            }
            else if (number == 8)
            {
                Console.WriteLine("Ağustos");
            }
            else if (number == 9)
            {
                Console.WriteLine("Eylül");
            }
            else if (number == 10)
            {
                Console.WriteLine("Ekim");
            }
            else if (number == 11)
            {
                Console.WriteLine("Kasım");
            }
            else if (number == 12)
            {
                Console.WriteLine("Aralık");
            }
            else
            {
                Console.WriteLine("Lütfen 1-12 arasında bir sayı girin.!!!");
            }
        }
    }
}
