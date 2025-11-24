namespace CarpmaKullanmadanCarpma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2;
            Console.WriteLine("Birinci sayıyı giriniz:");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz:");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            int total=0;

            for (int i = 0;i<sayi2;i++)
            {
                total += sayi1;
                 
            }
            Console.WriteLine(total);   

        }
    }
}
