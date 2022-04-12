using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("Corey");

           
            product.Price = 10;
            product.Totallncome = 0;
            product.Count = 5;

            product.Sell();
            product.Sell();
            product.Sell();
            product.Sell();
            product.Sell();
            product.Sell();
            

            Milk milk = new Milk("Milla");

            milk.Price = 2;
            milk.Totallncome = 0;
            milk.Count = 5;
            milk.Volume = "1 litr";
            milk.Fatrate = " 3.2% ";

            milk.Sell();
            milk.Sell();
            milk.Sell();
            milk.Sell();
            milk.Sell();
            milk.Sell();











        }
    }
}
