using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("ID: " + customer.Id);
            Console.WriteLine("Ad: " + customer.CustomerName);
            Console.WriteLine("Soyad: " + customer.CustomerSurname);
            Console.WriteLine("----------------------------");
            Console.WriteLine("Bilgileri Belirtilen Müşteri Başarıyla Veritabanına Eklendi...");
        }

        public void List(Customer[] customers)
        {
            foreach (Customer x in customers)
            {
                Console.WriteLine(x.Id + "-" + x.CustomerName + x.CustomerSurname);
            }

        }
    }
}
