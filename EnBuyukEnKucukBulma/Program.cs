namespace EnBuyukEnKucukBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi, sayi1, enBuyuk = 0, enKucuk = 99999999;
            Console.Write("Kaç sayı girmek istiyorsunuz: ");
            sayi=Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < sayi; i++)
            {
                Console.WriteLine("Sayı giriniz:");
                sayi1 = Convert.ToInt32(Console.ReadLine());

                if (sayi1 > enBuyuk)
                {
                    enBuyuk = sayi1;
                }

                if (sayi1 < enKucuk) 
                { 
                      enKucuk=sayi1;
                }


            }
            Console.WriteLine("En Büyük sayi: " + enBuyuk);
            Console.WriteLine("En Küçük sayi: " + enKucuk);
        }
    }
}
