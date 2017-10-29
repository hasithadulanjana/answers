using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class ExSevenModel
    {
        public int getAddValue(int startValue, int endValue)
        {
            
            
            int value = 0;
            for(value = startValue;value <= endValue; value++)
            {
                 value +=  startValue ;
                
            }
            return value;
        }

        public double getAvgValue(int startValue, int endValue)
        {
            int count = startValue - endValue+1;
            Console.WriteLine(count);
            return(double) this.getAddValue(startValue,endValue)/ count;
        }
    }
}
