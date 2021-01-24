using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = "255";
            customer1.CustomerName = "Mehmet";
            customer1.CustomerSurname = "Topal";
            Customer customer2 = new Customer();
            customer2.Id = "256";
            customer2.CustomerName = "ÖmerFaruk";
            customer2.CustomerSurname = "Topal";
            Customer customer3 = new Customer();
            customer3.Id = "257";
            customer3.CustomerName = "Can";
            customer3.CustomerSurname = "Capkan";

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };
            CustomerManager customermanager = new CustomerManager();
            customermanager.Add(customer1);
            customermanager.List(customers);

        }
    }
}
