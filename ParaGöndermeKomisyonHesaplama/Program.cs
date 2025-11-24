namespace ParaGöndermeKomisyonHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double limit, gonderilenPara;
            Console.Write("Hesap limitini giriniz: ");
            limit = double.Parse(Console.ReadLine());
            Console.Write("Göndermek istediğiniz miktarı giriniz: ");
            gonderilenPara = double.Parse(Console.ReadLine());

            if (limit > 0)
            {
                if (gonderilenPara <=  limit)
                {
                    if (gonderilenPara < 100 && gonderilenPara>0)
                    {
                        Console.Write(gonderilenPara + 1);

                    }
                    else if (100 < gonderilenPara && gonderilenPara > 1000)
                    {
                        Console.Write(gonderilenPara + 3);
                    }
                    else if (1000 < gonderilenPara)
                    {
                        Console.Write(gonderilenPara + 5);
                    }
                }
                else 
                {
                    Console.WriteLine("Bakiyeniz yetersizdir.Lütfen yükleme yapınız veya daha düşük miktar giriniz.!!!");
                }
            }
            else 
            {
                Console.WriteLine("Limitiniz yetersizdir.Lütfen yükleme yapınız.!!!");
            }

        }
    }
}   
