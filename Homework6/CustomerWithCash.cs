﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6_AbstractClassAndMethod
{    
    class CustomerWithCash : Customer
    {
        public override void Pay()
        {
            Console.WriteLine("Customer paid in cash");
        }
    }    
}

