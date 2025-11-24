namespace ElektronikAletlerinHarcadıgıGuc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Aletin harcadığı akım değerini giriniz:");
            double akim = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Aletin direnç değerini giriniz:");
            double direnc = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Aletin kaç saatçalışacağını giriniz:");
            double saat = Convert.ToDouble(Console.ReadLine());

            double fiyat = 0.7102;

            double power = (Math.Pow(akim, 2)) * direnc;

            double kwh = power * saat;

            double tutar = kwh * fiyat;

            Console.WriteLine(tutar);

        }
    }
}
