using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_två_for_real
{
    class Product
    {
        //public sträng produkt namn
        public string ProductName;
        //publik int produkt pris
        public int ProductPrice;
        //Konstruktor till class produkt, två parametrar som heter sätter Produktnamn och produkt pris
        public Product(string productName, int productPrice)
        {
            ProductName = productName;
            ProductPrice = productPrice;
        }
    }
}
