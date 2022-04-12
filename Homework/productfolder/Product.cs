using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    class Product
    {
       public string Name;
       public int Price;
       public int Count;
       public int Totallncome;

        public Product (string name)
        {
            Name = name;
        }
        public void Sell( )
        {
            if (Count > 0)
            {
                Count--;
                Totallncome += Price;

                Console.WriteLine($"Satish emelliyati\n{Totallncome} qazanc");
            }
            else { Console.WriteLine($"{Name} mehsulu anbarda bitmisdir!"); }
            

            
            
            
        }
       





    }
    


    
}
