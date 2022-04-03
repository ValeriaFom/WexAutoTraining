using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7_Interfaces
{
    class DevTeamLead : Employee, ITaskAssigner, ICodeReviewer, ICodeWriter
    {
        public void CodeWrite()
        {
            Console.WriteLine($"{ToString()} wrote a code.");
        }
        public void Review()
        {
            Console.WriteLine($"{ToString()} reviewed a task.");
        }
        public void TaskAssign()
        {
            Console.WriteLine($"{ToString()} assigned a task.");
        }

    }
}
