using System;
using System.Collections.Generic;
using System.IO;

namespace ShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# program to design shopping cart \n");
            Dictionary<string,int> cart = new Dictionary<string, int>();

            
            bool entry = true;

while(entry)
{
            Console.WriteLine("Press 1 to add item");
            Console.WriteLine("Press 2 to checkout");
            int input =Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1: 
            
                Console.WriteLine("Enter product name");
                string name = Console.ReadLine();

                Console.WriteLine("Enter product price");
                int price = Convert.ToInt32(Console.ReadLine());

                //cart.Add(name,price);
                if(!cart.ContainsKey(name))
                {
                    cart.Add(name,price);
                }
                else{
                    Console.WriteLine("Already added to cart");
                }
                break;
                

                case 2: 

                Console.WriteLine("Saving to a file");
                using (StreamWriter sw = new StreamWriter("cart.txt"))
                {
                    foreach(KeyValuePair<string,int> kv in cart)
                    {
                        Console.WriteLine(kv);
                        sw.WriteLine(kv);
                    }
                }
                
                
                entry = false;
                break;



            }


        }

        }
    }
}
