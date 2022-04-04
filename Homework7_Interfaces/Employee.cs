using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7and8_Interfaces_IComparer
{
    abstract class Employee: IComparable<Employee>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TaxID { get; set; }
        public string jobTitle;

        public override string ToString()
        {
            return FirstName + " " + LastName + ", " + jobTitle + ", " + TaxID;
        }

        public int CompareTo(Employee other)
        {
            return LastName.CompareTo(other.LastName);            
        }
    }
}
