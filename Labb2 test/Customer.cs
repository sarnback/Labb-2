using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_test
{
    class Customer
    {
        //Guid som genererar unika ID:n
        public Guid CustomerId { get; set; } = Guid.NewGuid();
        public string CustomerName { get; set; }
        public string CustomerPassword { get; set; }

        //Konstruktor
        public Customer(string customerName, string customerPassword)
        {
            CustomerName = customerName;
            CustomerPassword = customerPassword;
        }

    }
}
