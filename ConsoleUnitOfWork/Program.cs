using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkExample;

namespace ConsoleUnitOfWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer obj = new Customer();
            obj.Id = 1000;
            obj.CustomerName = "shiv";
            SimpleExampleUOW<Customer> o1 = new SimpleExampleUOW<Customer>();
            o1.Add(obj);
            obj = new Customer();
            obj.Id = 2000;
            obj.CustomerName = "xxxx";
            o1.Add(obj);
            o1.Committ();

            SimpleExampleUOW<Supplier> o2 = new SimpleExampleUOW<Supplier>();
            o2.Add(new Supplier());
            o2.Committ();
        }
    }
}
