namespace DikdörtgenAlanCevre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kisaKenar, uzunKenar;
            Console.WriteLine("Kısa kenarı gririniz:");
            kisaKenar =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Uzun kenarı gririniz:");
            uzunKenar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dikdörtgenin alanı : " + (kisaKenar*uzunKenar));
            Console.WriteLine("Dikdörtgenin cevresi : " + (2 * (kisaKenar + uzunKenar)));





        }
    }
}
