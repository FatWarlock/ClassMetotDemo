using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo1
{
    class CustomerManager
    {
        public void Add(Customer customer) 
        {
            Console.WriteLine("Customer Added.  " +  customer.FirstName);
        }
        public void Delete(Customer customer) 
        {
            Console.WriteLine("Customer Deleted.  " +  customer.FirstName);
        }
        public void List(List<Customer> customers)
        {


            foreach (var customer in customers)
            {
                Console.WriteLine("Id : " + customer.Id);
                Console.WriteLine("First Name : " + customer.FirstName);
                Console.WriteLine("Last Name : " + customer.LastName);
                Console.WriteLine("PhoneNumber : " + customer.Number);
                Console.WriteLine("Age : " + customer.Age);
            }
        }
    }
}
