using System;

namespace ClassMetotDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1234;
            customer1.Name = "Monica";
            customer1.Surname = "Gella";
            customer1.Sex = 'F';
            customer1.Age = 28;


            Customer customer2 = new Customer();
            customer2.Id = 789;
            customer2.Name = "Steve";
            customer2.Surname = "Jobs";
            customer2.Sex = 'M';
            customer2.Age = 51;


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.List(customer2);
            customerManager.Delete(customer1);
        }
    }
}
