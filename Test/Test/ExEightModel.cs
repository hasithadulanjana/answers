using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class ExEightModel
    {
        public int calOddnum(int highest)
        {
            int sum = 0;
            int start = 1;
            for (int i = start; i <= highest; i += 2)
            {
                sum += i;
            }
            return sum;
        }
        public float GetAverage(int highest)
        {
            int start = 1;
            int count = highest - start +1;
            return (float)this.calOddnum(highest) / count;
        }

    }
}
