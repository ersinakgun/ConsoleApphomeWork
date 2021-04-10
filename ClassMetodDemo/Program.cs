using System;

namespace ClassMetodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 1;
            musteri1.Adi = "okyanus";
            musteri1.Soyadi = "dalgası";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 2;
            musteri2.Adi = "parpara";
            musteri2.Soyadi = "farpara";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            musteriManager.List(musteriler);

            Console.ReadLine();
        }
    }
}
