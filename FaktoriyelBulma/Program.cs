namespace FaktöriyelBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int total = 1;
            Console.WriteLine("Faktöriyelini Almak İstediğiniz Sayıyı Giriniz: ");
            number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number ; i++)
            {
                total *= i;


            }
            Console.WriteLine("{0} sayısının Faktöriyeli = {1} ",number,total);
          

        }
    }
}
