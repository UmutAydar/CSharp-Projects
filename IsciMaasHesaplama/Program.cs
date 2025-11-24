namespace IscıMaasHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double calısmaUcreti, calısmaSaati, maas;
            Console.Write("Çalışma ücretini  giriniz: ");
            calısmaUcreti = Convert.ToDouble(Console.ReadLine());
            Console.Write("Çalıştığınız saati giriniz: ");
            calısmaSaati = Convert.ToDouble(Console.ReadLine());

            if (calısmaSaati < 40)
            {
                maas = calısmaUcreti * calısmaSaati;
                Console.Write("Maaşınız: " + maas);
            }
            else if (calısmaSaati >= 40) 
            {
                maas = 2 * (calısmaUcreti * calısmaSaati);
                Console.Write("Maaşınız: " + maas);
            }
        }
    }
}
