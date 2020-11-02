using CRMmodel.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRMmodel.services
{
    public class EshopService
    {
        public void MainProcess()
        {
            Console.WriteLine("CRM Application!");

            var product = Product.createProduct();
            var customer = Customer.createCustomer();

            Console.WriteLine(product);
            Console.WriteLine(customer);
            product.IncreasePriceIfBelowLimit(35);
            Console.WriteLine(product);

            var order2 = new Order
            {
                Customer = new Customer { CustomerName = "Aris", Balance = 0, RegistrationDate = DateTime.Now },
                Products = new List<Product> { new Product { Name = "Chips", Price = 1.2m, InventoryQuantity = 30 } },
                Date = DateTime.Now
            };

        }

    }
}
