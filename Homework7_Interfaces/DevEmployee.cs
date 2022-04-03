using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7_Interfaces
{
    class DevEmployee : Employee, ICodeWriter
    {
        public string programmingLanguage { get; set; }
        public void CodeWrite()
        {
            Console.WriteLine($"{ToString()} wrote a code.");
        }        
    }
}
