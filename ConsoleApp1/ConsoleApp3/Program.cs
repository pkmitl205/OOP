using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    // Polymorphism

    class CustomerData // base class
    {
        public virtual void CustomerPhone()
        {
            Console.WriteLine("02 123 456");
        }
        public virtual void ClearAll()
        {
            Console.WriteLine("delete all data");
        }
    }

    // Inheritance from class CustomerData
    class CustomerData2 : CustomerData // derived class
    {
        public override void CustomerPhone()
        {
            base.CustomerPhone(); // method base class
            Console.WriteLine("02 123 456 7"); // new edit method
        }
        public new virtual void ClearAll()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CustomerData CustomerData = new CustomerData();
            //02 123 456
            CustomerData.CustomerPhone();
            //delete all data
            CustomerData.ClearAll();

            CustomerData2 CustomerData2 = new CustomerData2();
            CustomerData2.CustomerPhone();
            //02 123 456
            //02 123 456 7
            CustomerData2.ClearAll();
            //
    }
    }
}
