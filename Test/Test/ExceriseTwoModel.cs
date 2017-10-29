using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class ExceriseTwoModel
    {
        public string checkNumber(int number)
        {
            string result;
            if(number/2 != 0)
            {
                result = "Even";
            }
            else
            {
                result = "Odd";
            }
            return result;
        }
    }
}
