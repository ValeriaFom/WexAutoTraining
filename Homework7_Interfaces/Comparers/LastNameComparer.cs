using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7and8_Interfaces_IComparer.Comparers
{
    class LastNameComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if (x.LastName[0] > y.LastName[0])
            {
                return 1;
            }
            else if (x.LastName == y.LastName)
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
