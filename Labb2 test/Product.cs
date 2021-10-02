using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_test
{
   public class Product
    {
        //property produkt namn som man kan hämta och sätta värde
        public string ProductName{ get; set; }
        //property produkt pris som man kan hämta och sätta värde
        public double ProductPrice { get; set; }
        //Konstruktor när man gör en produkt
        public Product(string productName, int productPrice)
        {
            ProductName = productName;
            ProductPrice = productPrice;
        }

        


    }
}
