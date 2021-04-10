using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{//manager, service gibi isimler götünce anlamalıyızki orada silme ekleme güncelleme gibi operasyonlar var
  //listeleme, arama, filtreleme
    class ProductManager
    {//methodumuzun nasıl çağrılacağını anlattığı yer
        public void Add(Product product)
        {
            //sen bana product türünde bir şey göndericeksin ben onu product ismiyle tutuyor olacağım diyor
            //program.cs den geliyor

            Console.WriteLine(product.ProductName +"eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi.");
        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }
        //void in mantığı git yap bitir. örneğin çıkan sonuca çarpma işlemi uygulamak istiyoruz.voidde olmaz
        //bunun için int tipini, returnları kullanırız
    }
}
