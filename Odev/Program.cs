using System;

namespace Odev
{
    class Program
    {

        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.UrunAdi = "terlik";
            product1.UrunFiyati = 10;
            product1.UrunYorumlar = "tıkla";

            Product product2 = new Product();
            product2.UrunAdi = "masa";
            product2.UrunFiyati = 400;
            product2.UrunYorumlar = "tıklayınn";

            Product[] products = new Product[]
            {
                product1,product2 };
            for (int i = 0; i<products.Length; i++)
            {
                Console.WriteLine(products[i]);
                    }

        }
        class Product
        {
            public string UrunAdi { get; set; }
            public int UrunFiyati { get; set; }
            public string UrunYorumlar { get; set; }
        }

    
    }
}