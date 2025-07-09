using System;

namespace ProductApp
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Product product1 = new Product();
            product1.Id = 1;
            product1.Name = "Laptop";
            product1.Price = 50000;
            product1.DiscountPercentage = 10;

          
            Product product2 = new Product();
            product2.Id = 2;
            product2.Name = "Smartphone";
            product2.Price = 20000;
            product2.DiscountPercentage = 5;

       
            Console.WriteLine("Product 1 Details:");
            Console.WriteLine("ID: " + product1.Id);
            Console.WriteLine("Name: " + product1.Name);
            Console.WriteLine("Price: Rs" + product1.Price);
            Console.WriteLine("Discounted Price: Rs" + product1.GetDiscountedPrice());

            Console.WriteLine(); 

            
            Console.WriteLine("Product 2 Details:");
            Console.WriteLine("ID: " + product2.Id);
            Console.WriteLine("Name: " + product2.Name);
            Console.WriteLine("Price: Rs" + product2.Price);
            Console.WriteLine("Discounted Price: Rs" + product2.GetDiscountedPrice());
        }
    }
}
