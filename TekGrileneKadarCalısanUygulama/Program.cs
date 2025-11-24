namespace TekGrileneKadarCalısanUygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;
               
            do
            {

                Console.WriteLine("Bir sayi giriniz:");
                int number =Convert.ToInt32(Console.ReadLine());

                sayi = number % 2;


            } while (sayi == 0);
        }
    }
}
