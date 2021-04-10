using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CetegoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;
            //alttaki şekilde de gösterim mevcuttur
            Product product2 = new Product {Id=2, CetegoryId=5,
            UnitsInStock=5, ProductName="Kalem", UnitPrice=35 };
            //gerçek hayatta verileri kullanıcı girecek burada simüle ediyoruz

            //PascalCase   //camelCase
            //case sensitive: küçük harf duyarlı
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            productManager.Topla2(3, 6);
            int toplamaSonucu = productManager.Topla(3, 6);
            Console.WriteLine(toplamaSonucu*2);
            //int,double, bool...değer tip
            //diziler,class, interface,abstract class...referans tip
            //referansta atamalar, referansın numarasıyla(bellekteki adres) yapılır

        }
    }
}
