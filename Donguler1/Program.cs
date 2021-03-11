using System;

namespace Donguler1
{
    class Program
    {
        //döngüleri birbirine benzeyen işleri 
        //tekrar etmek için kullanırız
        static void Main(string[] args)
        {
            string kurs1 = "kdjskd";
            string kurs2 = "skksksk";
            string kurs3 = "hdjdj";
            //array - dizi,üstteki yanlış olur
            //bir dizi nasıl tanımlanır

            string[] kurslar = new string[] {
            "kdjskd", "skksksk", "hdjdj","abcx"
            };

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
                //genel amaçlar için
            }
            Console.WriteLine("for bitti");
            foreach (string kurs in kurslar)
            {
                // kursları tek tek dolaş
                //dizi temelli yapıları tek tek dönmeye yarıyor
                Console.WriteLine(kurs);
                //dizileri kolay dolaşmak için
            }
           
            Console.WriteLine("sayfa sonu-footer");
        //bir dizi tanımladık döngüyle yazdırdık
        }

    }
}
