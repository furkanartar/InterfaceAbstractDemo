using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using InterfaceAbstractDemo.Adapters;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager baseCustomerManager = new NeroCustomerManager();
            baseCustomerManager.Save(new Customer { DateOfBirth = new DateTime(1999, 1, 1), FirstName = "Furkan", LastName = "ARTAR", NationalityId = 12345678910 });
            Console.ReadLine();
        }
    }
}
