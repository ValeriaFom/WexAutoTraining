using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7and8_Interfaces_IComparer
{
    class QATeamLead : Employee, ITaskAssigner
    {
        public void TaskAssign()
        {
            Console.WriteLine($"{ToString()} assigned a task.");
        }
    }
}
