namespace KDVBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double urun, sonFiyat;

            Console.WriteLine("Ürünün Fiyatını Giriniz:");
            urun=Convert.ToDouble(Console.ReadLine());

            sonFiyat = urun + (urun * 18) / 100;
           
            sonFiyat =Math.Round(sonFiyat,2);

            Console.WriteLine("Ürünün KDV dahil fiyatı: "+sonFiyat);


        }
    }
}
