using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo1
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.Surname + " Successfully Added.");
        }

        public void List(Customer customer)
        {
            Console.WriteLine(customer.Id + " " + customer.Name + " " + customer.Surname + " Successfully Listed.");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.Surname + " Successfully Deleted.");
        }
    }
}