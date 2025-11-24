namespace SayiNegatiMifPozitifMi
{
    internal class Program
    {
        static void Main(string[] args)
        {

                Console.WriteLine("Bir Sayı Giriniz: ");
                double number = Convert.ToDouble(Console.ReadLine());

                if (number > 0)
                {
                    Console.WriteLine("Sayı Pozitiftir.");
                }
                else if (number == 0)
                {
                    Console.WriteLine("Sayı 0'dır. ");
                }
                else
                {
                    Console.WriteLine("Sayı Negatiftir");
                }
        }
    }
}
