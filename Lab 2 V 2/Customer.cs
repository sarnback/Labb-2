using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_V_2
{
    class Customer
    {
        public string CustomerLogin;
       public string CustomerPassword;
        int CustomerID;
        public Customer(string aCustomerLogin, string aCustomerPassword, int aCustomerID)
        {
            CustomerLogin = aCustomerLogin;
            CustomerPassword = aCustomerPassword;
            CustomerID = aCustomerID;
        }
    }
}
