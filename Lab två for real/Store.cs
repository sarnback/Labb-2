using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_två_for_real
{
    class Store
    {
        public List<Product> ProductsInStore;
        //Bool som håller igång affären efter användare loggat in
        public bool runStore = true;
        //referens till LogInManager class för få åtkomst i Store class
        public LogInManager LogInManager;        
        //Konstruktor med Produkter
        public Store()
        {           
            ProductsInStore = new List<Product>
            {
                new Product("JABBA JUICE", 29),
                new Product("CARBON FREEZE", 31),
                new Product("BATUU BIT", 19),
                new Product("Grogu´s Handpicked frog egg", 99)
             };
        }
        //Kör affären och hämtar menyn
        public void RunStore(LogInManager logInManager)
        {
            LogInManager = logInManager;
            runStore = true;
            while (runStore == true)
            {
                GetStoreMenu();
            }
        }
        //hämtar menyn
        public void GetStoreMenu()
        {
            PrintMenu();
            //parsar en knapp till en char hämtar unicode char från knappen
            var userInput = Console.ReadKey().KeyChar;
            Console.Clear();
            switch (userInput)
            {
                case '1':
                    AddProductToCartMenu();
                    break;
                case '2':
                    ShowShoppingCart();
                    break;
                case '3':
                   PayForAllProducts();
                    break;
                case '4':
                    LogInManager.Logout();
                    runStore = false;
                    break;
                case '5':
                    ExitShop();
                    break;
                default:
                    PrintWrongInput();
                    break;
            }
        }        
        //metod för fel input
        private static void PrintWrongInput()
        {
            Console.WriteLine("Wrong input try again");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        //metod för betala
        private void PayForAllProducts()
        {
           LogInManager.LogedInCustomer.GetTotalCost();
        }
        //metod för avsluta affär
        private static void ExitShop()
        {
            Console.WriteLine("Exiting shop");
            Environment.Exit(0);
        }
        //metod för att visa kundvagn
        private void ShowShoppingCart()
        {
            LogInManager.LogedInCustomer.ToString();
            Console.WriteLine();
            Console.WriteLine("Press any key to leave cart");
            Console.ReadKey();
            Console.Clear();
        }
        //metod för lägga till vara i kundkorg med switch case
        private  void AddProductToCartMenu()
        {
            for (int i = 0; i < ProductsInStore.Count; i++)
            {
                Console.WriteLine($"{i+1} Pruduct: {ProductsInStore[i].ProductName}  Imperial Credits: {ProductsInStore[i].ProductPrice}");
            }
            var userInputProduct = Console.ReadKey(true).KeyChar;
            switch (userInputProduct)
            {
                case '1':
                    Console.WriteLine($"How many {ProductsInStore[0].ProductName} do you wanna add?");
                    string userInputAsString = Console.ReadLine();
                    int userInput;
                    bool success = int.TryParse(userInputAsString, out userInput);
                    if (success)
                    {
                        for (int i = 1; i <= userInput; i++)
                        {
                            LogInManager.LogedInCustomer.AddItemToCart(new Product(ProductsInStore[0].ProductName, ProductsInStore[0].ProductPrice));
                        }
                        if (userInput > 1)
                        {
                            Console.WriteLine($"You added {userInput} {ProductsInStore[0].ProductName}");
                        }
                        else if (userInput == 1)
                        {
                            Console.WriteLine($"You added {userInput} {ProductsInStore[0].ProductName}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong input..Typical Wookiee behaviour..");
                    }
                    break;
                case '2':
                    Console.WriteLine($"How many {ProductsInStore[1].ProductName} do you wanna add?");
                     userInputAsString = Console.ReadLine();
                     success = int.TryParse(userInputAsString, out userInput);
                    if (success)
                    {
                        for (int i = 1; i <= userInput; i++)
                        {
                            LogInManager.LogedInCustomer.AddItemToCart(new Product(ProductsInStore[1].ProductName, ProductsInStore[1].ProductPrice));
                        }
                        if (userInput > 1)
                        {
                            Console.WriteLine($"You added {userInput} {ProductsInStore[1].ProductName}");
                        }
                        else if (userInput == 1)
                        {
                            Console.WriteLine($"You added {userInput} {ProductsInStore[1].ProductName}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong input..Don´t waste my time");
                    }
                    break;
                case '3':
                    Console.WriteLine($"How many {ProductsInStore[2].ProductName} do you wanna add?");
                    userInputAsString = Console.ReadLine();
                    success = int.TryParse(userInputAsString, out userInput);
                    if (success)
                    {
                        for (int i = 1; i <= userInput; i++)
                        {
                            LogInManager.LogedInCustomer.AddItemToCart(new Product(ProductsInStore[2].ProductName, ProductsInStore[2].ProductPrice));
                        }
                        if (userInput > 1)
                        {
                            Console.WriteLine($"You added {userInput} {ProductsInStore[2].ProductName}s");
                        }
                        else if (userInput == 1)
                        {
                            Console.WriteLine($"You added {userInput} {ProductsInStore[2].ProductName}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong input you Fuzzball..");
                    }
                    break;
                case '4':
                    Console.WriteLine($"How many {ProductsInStore[3].ProductName} do you wanna add?");
                    userInputAsString = Console.ReadLine();
                    success = int.TryParse(userInputAsString, out userInput);
                    if (success)
                    {
                        for (int i = 1; i <= userInput; i++)
                        {
                            LogInManager.LogedInCustomer.AddItemToCart(new Product(ProductsInStore[3].ProductName, ProductsInStore[3].ProductPrice));
                        }
                        if (userInput > 1)
                        {
                            Console.WriteLine($"You added {userInput} {ProductsInStore[3].ProductName}s");
                        }
                        else if (userInput == 1)
                        {
                            Console.WriteLine($"You added {userInput} {ProductsInStore[3].ProductName}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong input.. Clanker...");
                    }
                    break;
                default:
                    Console.WriteLine("Wrong input try again");
                    break;
            }
        }
        //metod för skriva ut menyn efter inloggning
        private void PrintMenu()
        {
            Console.WriteLine("===================================");
            Console.WriteLine($" USER: {LogInManager.LogedInCustomer.CustomerName}");
            Console.WriteLine("===================================");
            Console.WriteLine(" Press \"1\" to browse our products");
            Console.WriteLine(" Press \"2\" to see your shopping cart");
            Console.WriteLine(" Press \"3\" to end purchase");
            Console.WriteLine(" Press \"4\" to logout              ");
            Console.WriteLine(" Press \"5\" to exit");
            Console.WriteLine("===================================");
        }
    }
    }
