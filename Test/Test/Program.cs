using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            new Controller(new ConsoleView(), new Model(), new ExceriseTwoModel(), new ExThreeModel(), new ExFourModel(), new ExFiveModel()
                , new ExSixModel(), new ExSevenModel(), new ExEightModel()).Go();

        }
    }
}
