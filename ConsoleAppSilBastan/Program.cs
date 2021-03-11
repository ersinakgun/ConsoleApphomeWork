using System;

namespace ConsoleAppSilBastan
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety : tip güvenliği
            //do not repeat yourself : kendiini tekrarlama 
            //değer tutucu(kategori etiketi)
            string kategoriEtiketi = "kategorilerxxx";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("azalış");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("artış");
            }
            else
            {
                Console.WriteLine("eşittir(değişmedi butonu");
            }

            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine("KULLANICI AYARLARI BUTONU");
            }

            else
            {
                Console.WriteLine("giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);

           


        }
    }
}
