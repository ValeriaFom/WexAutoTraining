using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7and8_Interfaces_IComparer.Comparers
{
    class FullNameLengthComparer : IComparer<Employee>
    {
        //int fnLength = Employee.FirstName.Length + Employee.LastName.Length;  //почему тут нельзя прописать?
        public int Compare(Employee x, Employee y)
        {
            int xFullNameLength = x.FirstName.Length + x.LastName.Length;
            int yFullNameLength = y.FirstName.Length + y.LastName.Length;

            if (xFullNameLength > yFullNameLength)
            {
                return 1;
            }
            else if (xFullNameLength == yFullNameLength)
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
