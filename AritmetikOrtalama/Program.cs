namespace AritmetikOrtalama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
            double sayi1;
            double ort = 0;

            Console.WriteLine("Lütfen kaç sayı girmek istediğinizi giriniz: ");
            sayi= Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < sayi; i++)
            {
                Console.WriteLine("Sayi giriniz: ");
                sayi1 = Convert.ToDouble(Console.ReadLine());
                ort += sayi1;
            }

            Console.WriteLine("Sayıların ortalaması: " + (ort/sayi));
        }
    }
}
