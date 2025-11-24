namespace DovizHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            double tl, usd, euro, sterlin, ruble, gramAltın;
            Console.Write("Para miktarını giriniz:");
            tl = Convert.ToDouble(Console.ReadLine());

            usd = tl / 35.75;
            euro = tl / 37.33;
            gramAltın = tl / 3149.74;
            sterlin = tl / 44.49;
            ruble = tl / 0.36;

            Console.WriteLine("Elinizdeki TL ile; \n{0} Dolar \n{1} Euro \n{2} Gram Altın \n{3} \n{4} Gram Altın Sterlin alabilirsiniz.", usd, euro, gramAltın, sterlin,ruble);


        }
    }
}
