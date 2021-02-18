using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbsractDemo.Abstract;
using InterfaceAbsractDemo.Concercate;
using InterfaceAbsractDemo.Entities;

namespace InterfaceAbsractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.name = "Engin";
            customer.surname= "Demiroğ";
            customer.natiolanityId= "Demiroğ";
            customer.DateOfBirth= new DateTime(1985,1,6);
            BaseCustomerManager baseCustomerManager = new NeroCustomerManager(new CustomerCheckManager());
            baseCustomerManager.Save(customer);

            Console.ReadKey();

        }
    }
}
