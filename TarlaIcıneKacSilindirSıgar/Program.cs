namespace TarlaIcıneKacSilindirSıgar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Alanınızın hacmini metreküp cinsinden giriniz:");
            double toplamAlan = Convert.ToDouble(Console.ReadLine());

            Console.Write("Alanınızın hacmini metreküp cinsinden giriniz:");
            double r = Convert.ToDouble(Console.ReadLine());

            Console.Write("Alanınızın hacmini metreküp cinsinden giriniz:");
            double h = Convert.ToDouble(Console.ReadLine());

            double hacim = (3.14) * (Math.Pow(r, 2) * h);

            int silindirSayisi = Convert.ToInt32(toplamAlan / hacim);

            Console.WriteLine($"Girdiğiniz alana {silindirSayisi} tane silindir sığar!");

        }
    }
}
