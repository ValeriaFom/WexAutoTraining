using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7_Interfaces
{
    interface ICodeWriter
    {
        void CodeWrite()
        {
            Console.WriteLine($"Employee wrote a code."); //можно ли как-то вызвать этот метод (на интерфейсе), минуя его на объектах?
        }
    }
}