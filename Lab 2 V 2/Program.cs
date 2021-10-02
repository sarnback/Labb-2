using System;

namespace Lab_2_V_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VÄLKOMMEN TILL LAB 2 :D");
            var apple = new Product("Äpple ", 9);
            var banana = new Product("Banan ", 10);
            var pinapple = new Product("Ananas ", 19);
            ShoppingCart addedItem = new ShoppingCart();
            addedItem._ShoppingCart.Add(apple);
            addedItem._ShoppingCart.Add(banana);    

            Console.WriteLine(apple.ProductName + apple.ProductPrice +" kr");
            Console.WriteLine(banana.ProductName + banana.ProductPrice +" kr");
            Console.WriteLine(pinapple.ProductName + pinapple.ProductPrice + " kr");
            Console.WriteLine("Skriv in ditt login och lösenord");
            var customer1 = new Customer(Console.ReadLine(), Console.ReadLine(),1);
           
            Console.WriteLine(customer1.CustomerLogin + customer1.CustomerPassword);
            Console.ReadKey();
           



        }
    }
}
