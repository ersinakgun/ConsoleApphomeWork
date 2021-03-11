using System;

namespace Classİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "ENGİN";
            int yas = 36;
//değerleri atamak için yapacağın bu
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.Egitmen = "engin";
            kurs1.İzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "python";
            kurs2.Egitmen = "ergin";
            kurs2.İzlenmeOrani = 72;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "java";
            kurs3.Egitmen = "kerem";
            kurs3.İzlenmeOrani = 64;

            // Console.WriteLine(kurs1.KursAdi + " : "+
            //kurs1.Egitmen);
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3};
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs3.KursAdi+":"+kurs3.Egitmen);

            }
        }
    }

    class Kurs
    {
        //class tanımlamakiçin yapacağın bu
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int İzlenmeOrani { get; set; }
    }
}
