using System;
using System.Collections.Generic;

namespace ClassMetotDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                Id = 1,
                FirstName = "Fat",
                LastName = "Yıl",
                Number = "12345",
                Age = 19
            };
            Customer customer2 = new Customer()
            {
                Id = 2,
                FirstName = "Ber",
                LastName = "Öz",
                Number = "2345",
                Age = 20,
            };
            List<Customer> customers = new List<Customer> { customer1, customer2 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Delete(customer1);
            customerManager.Delete(customer2);
            customerManager.List(customers);
        }
        
    }
}
