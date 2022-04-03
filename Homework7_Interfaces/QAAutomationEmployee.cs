using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7_Interfaces
{
    class QAAutomationEmployee : Employee, ICodeWriter
    {
        public void CodeWrite()
        {
            Console.WriteLine($"{ToString()} wrote a code.");
        }
    }
}
