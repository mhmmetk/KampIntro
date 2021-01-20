using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{//snippet
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }//ürün ismi
        public double UnitPrice { get; set; }//ürünün birim fiyatı
        public int UnitsInStock { get; set; }//ürün stok adedi
        //crud-create read update delete


    }
}
