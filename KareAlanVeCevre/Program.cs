namespace KareAlanVeCevre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edge;

            Console.WriteLine("Karenin bir kenarını giriniz: ");

            edge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Karenin Çevresi: " + (4 * edge));
            Console.WriteLine("Karenin Alanı: " + (edge * edge));



        }
    }
}
