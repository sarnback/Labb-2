using System;

namespace Labb2_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customerOne = new Customer("Knatte", "123");
            Customer customerTwo = new Customer("Fnatte", "321");
            Customer customerThree = new Customer("Tjatte", "213");
            Customer logedInCustomer = new Customer("","");
            
            
            


            //Kund1: Namn="Knatte", Password="123"
            //Kund2: Namn = "Fnatte", Password = "321"
            //Kund3: Namn = "Tjatte", Password = "213"
            Console.WriteLine("Welcome to this awesome e-shop");
            Console.WriteLine("Press 1 to login");
            Console.WriteLine("Press 2 to create new user");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("LOGIN");
                    
                   
                   
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("Create new user");
                    Console.WriteLine("New username:");
                    string newUsername = Console.ReadLine();
                    Console.WriteLine("New password:");
                    string newPassword = Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("No valid answer.. Please try again");
                    Console.Clear();
                    break;
            }
            //Skapar nya produkter,ger dem namn och pris från min constructor i "Product.cs"
            Product apple = new Product("Green succulent Apple", 7);
            Product bananas = new Product("Big yellow Banana", 9);
            Product orange = new Product("Ripe Orange", 8);
            Product softDrink = new Product("Grogu´s frogegg Softdrink", 15);
            Product popsicle = new Product("Mance Windu´s icy lightsaber", 19);
            //Guid customerId = Guid.NewGuid();
            //Console.WriteLine(customerId);

            Console.WriteLine(apple.ProductName + " " + apple.ProductPrice + "kr");
            Console.WriteLine(bananas.ProductName + " " + bananas.ProductPrice + "kr");
            Console.WriteLine(orange.ProductName + " " + orange.ProductPrice + "kr");
            Console.WriteLine(softDrink.ProductName + " " + softDrink.ProductPrice + "kr");
            Console.WriteLine(popsicle.ProductName + " " + popsicle.ProductPrice + "kr");

            shoppingCart shoppingCartItem = new shoppingCart();
            shoppingCartItem.ShoppingList.Add(apple);
            shoppingCartItem.ShoppingList.Add(bananas);
            shoppingCartItem.ShoppingList.Add(orange);
            shoppingCartItem.ShoppingList.Add(softDrink);
            shoppingCartItem.ShoppingList.Add(popsicle);
            double total = shoppingCartItem.GetTotalCost();
            Console.WriteLine("Store value is " + total);

            Console.ReadLine();
        }
    }
}
      
   