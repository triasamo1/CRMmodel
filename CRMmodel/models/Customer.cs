using System;
using System.Collections.Generic;
using System.Text;

namespace CRMmodel.models
{
    public class Customer
    {
        public string CustomerName { get; set; }
        public float Balance { get; set; }
        public DateTime RegistrationDate { get; set; }

        public override string ToString()
        {
            return "CustomerName: " + CustomerName
                + " Balance: " + Balance + " RegistrationDate: " + RegistrationDate;
        }

        public static Customer createCustomer()
        {
            Console.WriteLine("Give name of Customer");
            string customerName = Console.ReadLine();

            var customer = new Customer
            {
                CustomerName = customerName,
                Balance = 0,
                RegistrationDate = DateTime.Now
            };

            return customer;
        }
    }
}
