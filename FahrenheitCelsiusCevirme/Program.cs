namespace FahrenheitCelsiusCevirme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double f, c;
            Console.WriteLine("Sıcaklığı fahrenheit türünden giriniz: ");
            f=Convert.ToDouble(Console.ReadLine());

            c = (f - 32) * 5 / 9;

            Console.WriteLine("Sıcaklık deeriniz: "+c);
        }
    }
}
