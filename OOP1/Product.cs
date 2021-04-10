using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //snippet ..bu tip claslarda sadece özellik olur
    class Product 
    {
        public int Id { get; set; }
        public int CetegoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        //CRUD ekle oku güncelle sil operasyonları
    }   
}
