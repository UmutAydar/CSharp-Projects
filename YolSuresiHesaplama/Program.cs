namespace YolSuresiHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gidilecek mesafeyi kilometre cinsinden giriniz:");
            double mesafe = Convert.ToDouble(Console.ReadLine());

            Console.Write("Yol boyunca ortalama hızı kilometre/saat cinsinden giriniz:");
            double hız = Convert.ToDouble(Console.ReadLine());

            double t = mesafe / hız;

            Console.WriteLine($"Girdiğiniz mesafe ortalama olarak {t} saat sürecektir.");
        }
    }
}
