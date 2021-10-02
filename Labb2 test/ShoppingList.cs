using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_test
{
    public class shoppingCart
    {
        public List<Product> ProductList { get; set; }

        public List<Product> ShoppingList;

        public shoppingCart()
        {
            ProductList = new List<Product>();
            ShoppingList = new List<Product>();
        }
        public double GetTotalCost()
        {
            //Initierar total kostnad 0
            double totalCost = 0;
            foreach (var product in ShoppingList)
            {
                totalCost = totalCost + product.ProductPrice;
            }
            return totalCost;
        }

    }
}
