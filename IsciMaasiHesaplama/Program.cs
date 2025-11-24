namespace IsciMaasıHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double maas, ekMaas;
            int cocukSayisi;

            Console.Write("Maaşınızı Giriniz:");
            maas =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Çocuk Sayısınız Giriniz:");
            cocukSayisi =Convert.ToInt32(Console.ReadLine());


            if (cocukSayisi == 1)
            {
                ekMaas = (maas * 5) / 100;
                Console.WriteLine("Alacağınız Ek Maaş:" + ekMaas);
                Console.WriteLine("Alacağınız Toplam Maaş:" + (ekMaas+maas));
            }
            else if (cocukSayisi == 2)
            { 
                ekMaas = (maas * 10) / 100;
                Console.WriteLine("Alacağınız Ek Maaş:" + ekMaas);
                Console.WriteLine("Alacağınız Toplam Maaş:" + (ekMaas + maas));
            }
            else if(cocukSayisi >= 3)
            {
                ekMaas = (maas * 15) / 100;
                Console.WriteLine("Alacağınız Ek Maaş:" + ekMaas);
                Console.WriteLine("Alacağınız Toplam Maaş:" + (ekMaas + maas));
            }
            else 
            {
                Console.WriteLine("Ek maaş alamazsınız");
            }

        }
    }
}
