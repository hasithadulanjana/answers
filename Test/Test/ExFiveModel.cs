using System;

namespace Test
{
     class ExFiveModel
    {
        public int addvalues(int val)
        {
            int sum = 0;
            int count = 1;
            while(count <= val)
            {
                sum += count;
                count++;
            }
            return sum;
        }

        public float avgValues(int val)
        {
            return (float)this.addvalues(val) / val;
        }
    }
}