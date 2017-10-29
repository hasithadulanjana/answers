using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class ExTenModel
    {
        public int FindSquresRoot(int lowestNumber, int highestNumber)
        {
            int squNum = 0;
            for(int counter = lowestNumber; counter <= highestNumber; counter++)
            {
                squNum = counter * counter;
            }
            return squNum;
        }
    }
}
