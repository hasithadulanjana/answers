using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class ExFourModel
    {
        public  int SumValue(int max)
        {
            int result = 0;
            for(int x =1; x <=100; x++)
            {
                result += x;
            }
            return result;
        }

        public float AvgValue(int max)
        {
            return (float) this.SumValue(max)/max;
        }
    }
}
