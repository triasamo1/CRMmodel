using System;
using System.Collections.Generic;
using System.Text;

namespace CRMmodel.models
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InventoryQuantity { get; set; }

        public override string ToString()
        {
            return "Name: " + Name
                + " Price: " + Price + " InventoryQuantity: " + InventoryQuantity;
        }

        public void IncreasePriceIfBelowLimit(int limit)
        {
            if (InventoryQuantity < limit)
                Price += 1;
        }

        public static Product createProduct()
        {
            Console.WriteLine("Give name of product");
            string productName = Console.ReadLine();
            Console.WriteLine("Give price of product");
            decimal price = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("Give quantity of product");
            int quantity = Int32.Parse(Console.ReadLine());

            var product = new Product
            {
                Name = productName,
                Price = price,
                InventoryQuantity = quantity
            };

            return product;
        }
    }
}
