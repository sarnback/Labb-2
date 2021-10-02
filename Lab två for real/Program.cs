using System;

namespace Lab_två_for_real
{
    class Program
    {
        static void Main(string[] args)
        {
            var loggInManager = new LogInManager();
            var store = new Store();
            var customerOne = new Customer("Knatte", "123");
            var customerTwo = new Customer("Fnatte", "321");
            var customerThree = new Customer("Tjatte", "213");
            loggInManager.RegistredCustomers.Add(customerOne);
            loggInManager.RegistredCustomers.Add(customerTwo);
            loggInManager.RegistredCustomers.Add(customerThree);  
            //Hämtar kundvagn och visar den om man skriver ut den
            // gör en foreach loop för visa hela kundkorg    
            bool menuLoop = true;
            while(menuLoop)
            {
                if(loggInManager.LogedInCustomer == null)
                {
                    loggInManager.LogInMenu();
                }
                else if(loggInManager.LogedInCustomer != null)
                {
                    store.RunStore(loggInManager);
                }
                else
                {
                    Console.WriteLine();
                    Console.ReadKey();      
                }     
            }
        }
    }
}
