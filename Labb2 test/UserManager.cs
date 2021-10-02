using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_test
{
    class UserManager
    {
        public List<Customer> RegistredCustomer;

        Customer _LogedInCustomer;
        public UserManager()
        {
            RegistredCustomer.Add(_LogedInCustomer);
        }
        
        
        //gör lista utav customer registerdcustomer
        //gör en customer som heter LogedIncustomer
    }
}
