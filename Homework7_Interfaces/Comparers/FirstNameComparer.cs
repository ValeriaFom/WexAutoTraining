using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7and8_Interfaces_IComparer.Comparers
{
    class FirstNameComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if (x.FirstName[0] > y.FirstName[0])
            {
                return 1;
            }
            else if (x.FirstName == y.FirstName)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}
