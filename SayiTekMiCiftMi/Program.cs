namespace SayiTekMiCiftMi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir Sayı Giriniz");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0) 
            { 
                Console.WriteLine("Sayı Çifttir");
            }
            else 
            {
                Console.WriteLine("Sayi Tektir");
            }
        }
    }
}
