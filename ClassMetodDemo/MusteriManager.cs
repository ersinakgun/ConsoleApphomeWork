using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetodDemo
{
    class MusteriManager
    {
        public void List(Musteri[] musteriler)
        {

            foreach(var Musteri in musteriler)
            {
                Console.WriteLine(Musteri.MusteriId + " " + Musteri.Adi + " " + Musteri.Soyadi);

            }


        }
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Musteri Added : " + musteri.Adi + "" + musteri.Soyadi);
        }
        public void Delete (Musteri musteri)
        {
            Console.WriteLine("Musteri Deleted :" + musteri.Adi + "" + musteri.Soyadi);
        }

    }
}
