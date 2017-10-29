using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class ExElevnModel
    {
        public int FindProducts(int productNumber)
        {
            int product = 1;
            for (int i = 1; i <= productNumber; i++)
            {
                product *= i;
            }
            return product;
        }
    }
}
