using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_två_for_real
{
    class LogInManager
    {
        //Referens till Class Customer för att kunna använda metoder från Customer
        public Customer LogedInCustomer;       
        public List<Customer> RegistredCustomers;
        public LogInManager()
        {
            RegistredCustomers = new List<Customer>();
        }
        //Meny 1 för skapa & eller logga in som användare eller stänga affär
        public void LogInMenu()
        {
            Console.WriteLine("===================================");
            Console.WriteLine("|  MOS EISLEY CANTINA Online      |");
            Console.WriteLine("===================================");
            Console.WriteLine("| Press \"1\" to login              |");
            Console.WriteLine("| Press \"2\" to create new user    |");
            Console.WriteLine("| Press \"3\" to exit               |");
            Console.WriteLine("===================================");
            var userInput = Console.ReadKey().KeyChar;
            Console.Clear();
            //Om userInput ÄR 1, 2 eller 3 
            if (char.IsDigit(userInput))
            {
                switch (userInput)
                {
                    //Kallar på Login metod
                    case '1':
                        LogIn();
                        break;
                    //Kallar på Registrera anvädare metod
                    case '2':
                        RegisterUser();
                        break;
                    case '3':
                        //kallar på Avsluta affär metod
                        ExitShop();
                        break;
                    default:
                        //kallar på Skriv ut fel input metod
                        PrintWrongInputMessage();
                        break;
                }
            }
            //Felhantering OM userInput inte är en siffra mellan 1-3 så sker detta.
            else if (!char.IsDigit(userInput))
            {
                Console.WriteLine("Wrong input... Press any key to try again ");
                Console.ReadKey();
                Console.Clear();
            }
        }
        //Metod för stänga affären
        private static void ExitShop()
        {
            Console.WriteLine("You are leaving the shop");
            Environment.Exit(0);
        }
        //Metod för skriva ut fel input
        private static void PrintWrongInputMessage()
        {
            Console.WriteLine("Wrong input..Remember");
            Console.WriteLine("\"1\" to login");
            Console.WriteLine("\"2\" to create new user");
            Console.WriteLine("\"3\" to exit");
            Console.WriteLine("Press any key to try again");
            Console.ReadKey();
            Console.Clear();
        }
        //Metod för Registrera ny användare som sparas i Customer Class och läggs till i listan RegistredCustomers
        private void RegisterUser()
        {       
            Console.WriteLine();
            Console.Write("Username: ");
            string newUserName = Console.ReadLine();
            Console.Write("Passowrd: ");
            string newUserPassword = Console.ReadLine();
            var newCustomer = new Customer(newUserName, newUserPassword);
            Console.WriteLine($"New user created with the Username:\"{newUserName}\"");
            Console.WriteLine($"Password: \"{newUserPassword}\"");
            RegistredCustomers.Add(newCustomer);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        //Logga in och söker efter registrerad användare med linq och lambda metod
        private void LogIn()
        {
            Console.WriteLine("===================================");
            Console.WriteLine("LOGIN");
            Console.WriteLine("===================================");
            Console.Write("Username: ");
            string userName = Console.ReadLine();
            Console.Write("Password: ");
            string userPassword = Console.ReadLine();
            Console.Clear();
            //Jämför med lambda pilar ifall vi har en matchning med ny skapade variabel
            if (RegistredCustomers.Any(x => x.CustomerName == userName && x.CustomerPassword == userPassword))
            {
                Console.WriteLine("===================================");
                Console.WriteLine("WELCOME TO MOS EISLEY CANTINA");
                //Sparar en referenstyp av inloggad användare till LogedInCustomer
                LogedInCustomer = RegistredCustomers.Find(x => x.CustomerName == userName && x.CustomerPassword == userPassword);
            }
            //Om man skriver fel lösenord ELLER inte är registrerad så hamnar man här och console clear för rensa console
            else
            {
                Console.WriteLine("Wrong username or password");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }
        //Publik logout metod frågar om man vill logga ut, och sätter "LogedIncustomer till null, alltså rensar den som loggat in
        public void Logout()
        {
            Console.WriteLine("Do you want to logout?");
            Console.WriteLine(" \"Y\" = Yes \"N\" = No");
            string userInput = Console.ReadLine();
            if (userInput == "Y" || userInput == "y")
            {
                Console.WriteLine("You rebel scum!....");
                Console.WriteLine(" Press any key to continue");
                Console.ReadKey();
                LogedInCustomer = null;
            }
            else
            {
                Console.WriteLine("Going back.. Press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
