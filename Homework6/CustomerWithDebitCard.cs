using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6_AbstractClassAndMethod
{
    class CustomerWithDebitCard : Customer
    {
        public override void Pay()
        {
            Console.WriteLine("Customer paid by debit card");
        }
    }
}
