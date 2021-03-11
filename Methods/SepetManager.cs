using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    //manager gibi ifadeler operasyon tutuyor demek
    //syntax:yazım şekilleri
    class SepetManager
    {
        public void Ekle (Product urun)
      
        {
            Console.WriteLine("TEBRİKler sepete eklendi :"+urun.Adi+urun.Fiyati);

        }
        //alttaki yanlış bir gösterimdir
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("TEBRİKS! sepete eklendi :"+urunAdi);
        }
        //bir clasın içinde birden fazla metot olabilir
       
    }
}
