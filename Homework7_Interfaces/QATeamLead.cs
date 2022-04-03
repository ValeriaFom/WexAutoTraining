using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7_Interfaces
{
    class QATeamLead : Employee, ITaskAssigner
    {
        public void TaskAssign()
        {
            Console.WriteLine($"{ToString()} assigned a task.");
        }
    }
}
