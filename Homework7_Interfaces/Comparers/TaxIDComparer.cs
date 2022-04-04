using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7and8_Interfaces_IComparer.Comparers
{
    class TaxIDComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if (x.TaxID > y.TaxID)
            {
                return 1;
            }
            else if (x.TaxID == y.TaxID)
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
