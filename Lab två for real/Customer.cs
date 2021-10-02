using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_två_for_real
{
    class Customer
    {  
        //Readonly på Användarnamn
        public readonly string CustomerName;
        //Public string på Användarens Lösenord
        public string CustomerPassword;
        //Lista av class Produkt som heter _cart
        private List<Product> _cart;
        //publik lista av class produkt heter Cart  som returnar _cart
        public List<Product> Cart { get { return _cart; } }
        //Konstruktor av Customer, två sträng parametrar, När du skapar en ny användare så behöver man sätta customer namn och customer password
        public Customer(string customerName, string customerPassword)
        {
            CustomerName = customerName;
            CustomerPassword = customerPassword;
            _cart = new List<Product>();
            customerName.ToString();
        }
        //Skapat en metod som lägger in produkt i listan
        public void AddItemToCart(Product product)
        {
            _cart.Add(product);
        }
        //I klassen Kund skall det finnas en ToString() som skriver ut Namn, lösenord och kundvagnen på ett snyggt sätt.
        public void ToString()
        {
            Console.WriteLine("====================================");
            Console.WriteLine($"User Cart: {CustomerName}");
            Console.WriteLine($"User Password: {CustomerPassword}");
            Console.WriteLine("====================================");
            List<Product> jabbaJuice = Cart.Where(t => t.ProductName == "JABBA JUICE").ToList();
            List<Product> carbonFreeze = Cart.Where(t => t.ProductName == "CARBON FREEZE").ToList();
            List<Product> batuuBit = Cart.Where(t => t.ProductName == "BATUU BIT").ToList();
            List<Product> groguSnack = Cart.Where(t => t.ProductName == "Grogu´s Handpicked frog egg").ToList();
            if (Cart.Count == 0)
            {
                Console.WriteLine("===================================");
                Console.WriteLine("Your cart is empty");
                Console.WriteLine("===================================");
                //Early exit
                return;
            }
            PrintJabbaJuice(jabbaJuice);
            PrintCarbonFreeze(carbonFreeze);
            PrintBatuuBit(batuuBit);
            PrintGroguSnack(groguSnack);
        }

        private static void PrintJabbaJuice(List<Product> jabbaJuice)
        {
            if (jabbaJuice.Count != 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"You have {jabbaJuice.Count} Jabba Juice");
                Console.ResetColor();
            }
        }

        private static void PrintCarbonFreeze(List<Product> carbonFreeze)
        {
            if (carbonFreeze.Count != 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"You have {carbonFreeze.Count} Carbon Freeze");
                Console.ResetColor();
            }
        }

        private static void PrintBatuuBit(List<Product> batuuBit)
        {
            if (batuuBit.Count > 1)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"You have {batuuBit.Count} Batuu bits");
                Console.ResetColor();
            }
            if (batuuBit.Count == 1)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"You have {batuuBit.Count} Batuu bit");
                Console.ResetColor();
            }
        }

        private static void PrintGroguSnack(List<Product> groguSnack)
        {
            if (groguSnack.Count > 1)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"You have {groguSnack.Count} Grogu´s Handpicked frog eggs ");
                Console.ResetColor();
            }
            if (groguSnack.Count == 1)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"You have {groguSnack.Count} Grogu´s Handpicked frog egg ");
                Console.ResetColor();
            }
        }

        //Metod för välja och skriva ut kostnad
        public double GetTotalCost()
        {
            //Initierar total kostnad 0 
            double totalCost = 0;
            foreach (var product in Cart)
            {
                totalCost = totalCost + product.ProductPrice;
            }
            string userInput;
            double beskarParts, republicCredits;
            CurrencyChoice(totalCost, out userInput, out beskarParts, out republicCredits);
            switch (userInput)
            {
                case "1":
                    PaywithImperialCredits(totalCost);
                    break;
                case "2":
                    PayWithRepublicanCredits(republicCredits);
                    break;
                case "3":
                    PayWithBeskarParts(beskarParts);
                    break;
                default:
                    Console.WriteLine("Are u deaf? Pay now or.....");
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to end your purchase");
            Cart.Clear();
            Console.ReadKey();
            return totalCost;
        }

        private static void CurrencyChoice(double totalCost, out string userInput, out double beskarParts, out double republicCredits)
        {
            Console.WriteLine("How do you wanna pay?");
            Console.WriteLine("===================================");
            Console.WriteLine("1: Imperial Credits");
            Console.WriteLine("===================================");
            Console.WriteLine("2: Republic Credits");
            Console.WriteLine("===================================");
            Console.WriteLine("3: Beskar parts");
            Console.WriteLine("===================================");
            userInput = Console.ReadLine();
            beskarParts = totalCost * 0.01;
            republicCredits = totalCost * 2;
        }

        private static void PayWithBeskarParts(double beskarParts)
        {
            if (beskarParts == 1)
            {
                Console.WriteLine($"Your total cost is: ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(beskarParts);
                Console.ResetColor();
                Console.Write(" Beskar part");
                Console.WriteLine();
                Console.WriteLine("Thanks for that..Now get lost..");
                Console.WriteLine("This is the way");
            }
            if (beskarParts > 1 || beskarParts < 1)
            {
                Console.WriteLine($"Your total cost is: ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(beskarParts);
                Console.ResetColor();
                Console.Write(" Beskar parts");
                Console.WriteLine();
                Console.WriteLine("Thanks for that..Now get lost..");
                Console.WriteLine("I have spoken");
            }
        }

        private static void PayWithRepublicanCredits(double republicCredits)
        {
            if (republicCredits == 1)
            {
                Console.WriteLine($"Your total cost is: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(republicCredits);
                Console.ResetColor();
                Console.Write(" Republic Credit");
                Console.WriteLine();
                Console.WriteLine("Thanks for that..Now get lost..");
            }
            if (republicCredits > 1 || republicCredits < 1)
            {
                Console.WriteLine($"Your total cost is: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(republicCredits);
                Console.ResetColor();
                Console.Write(" Republic Credits");
                Console.WriteLine();
                Console.WriteLine("Thanks for that..Now get lost..");
            }
        }

        private static void PaywithImperialCredits(double totalCost)
        {
            if (totalCost == 1)
            {
                Console.WriteLine($"Your total cost is: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(totalCost);
                Console.ResetColor();
                Console.Write(" Imperial Credit");
                Console.WriteLine();
                Console.WriteLine("Thanks for that..Now get lost..");
            }
            if (totalCost > 1 || totalCost < 1)
            {
                Console.WriteLine($"Your total cost is: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(totalCost);
                Console.ResetColor();
                Console.Write(" Imperial Credits");
                Console.WriteLine();
                Console.WriteLine("Thanks for that..Now get lost..");
            }
        }
    }
}
