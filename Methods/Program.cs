using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { };
            //yukaarıda string arrayi oluşturduk içine hangisini koycaz
            Product urun1 = new Product();
            urun1.Adi = "ıspanak";
            urun1.Fiyati = 15;
            urun1.Aciklama = "amasya elması";
            urun1.StokAdedi = 4;

            Product urun2 = new Product();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "diyarbakır karpuzu";
            // şimdi product arrayi oluşturuyoruz
            Product[] urunler = new Product[] { urun1,urun2};
            //array eklediğin verileri tutan yapı
            //type safe: tip güvenli onun için productu yazıyoz aşağıda başta
            foreach (Product x in urunler)
            {
                Console.WriteLine(x.Adi);
                Console.WriteLine(x.Fiyati);
                Console.WriteLine(x.Aciklama);
                Console.WriteLine(x.StokAdedi);
                Console.WriteLine("-----------");
            }
            Console.WriteLine(" -----metotlar------");
            //İNSTANCE-ÖRNEK
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut","yyeşilll",12,10);
            sepetManager.Ekle2("elma", "yyeşil", 12,9);
            sepetManager.Ekle2("karpuz", "siyah", 12,8);
            sepetManager.Ekle2("karpuz", "siyah", 12, 8);
        }
    }
}
//METHOD BİZE TEKRAR TEKRAR KULLANABİLMEYİ SAĞLadı
//id eşsiz değer ör:tc no
//methotlar tekrar tekrar kullanımı sağlayan kod bloklarıdır.
//dont repeat yourself-dry:kendini tekrar etme
//clean code:temiz kod
//best practice:doğru uygulama teknikleri 
//bunu unutma.temel yapılar class lerın içinde olur