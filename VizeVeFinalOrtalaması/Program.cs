namespace VizeVeFinalOrtalaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vize, final;
            double sonuc = 0;
            Console.WriteLine("Vize notunuzu giriniz:");
            vize= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Final notunuzu giriniz:");
            final= Convert.ToInt32(Console.ReadLine());

            if (vize <0 || vize>100 || final<0 || final>100)
            {
                Console.WriteLine("Geçerli vize ve final notu giriniz.!!!");
            }
            else 
            {
                sonuc = (0.4 * vize) + (0.6 * final);
                Console.WriteLine(sonuc);
            }

           


        }
    }
}
