using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7_Interfaces
{
    abstract class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int taxID { get; set; }
        public string jobTitle;

        public override string ToString()
        {
            return firstName + " " + lastName + ", " + jobTitle;
        }
    }
}
