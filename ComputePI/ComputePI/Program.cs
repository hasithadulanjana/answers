using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputePI
{
    class Program
    {
        static void Main(string[] args)
        {
            new ComputePiController(new ConsoleView(), new ComputePi()).Go();
        }
    }
}
