using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class ExSixModel
    {
        public int calualteValues(int value)
        {
            int sum = 0;
            int count = 1;
            do
            {
                sum += count;
                count++;
            } while (count <= value);
            return sum;
        }

        public double avgCal(int value)
        {
            return (double)this.calualteValues(value) / value;
        }
    }
}
