using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class ExThreeModel
    {
        public string sayNumber(int digit)
        {
            string display;
            switch (digit)
            {
                case 0:
                    display ="Zero";
                    break;
                case 1:
                    display = "One";
                    break;
                case 2:
                    display = "Two";
                    break;
                case 3:
                    display = "Three";
                    break;
                case 4:
                    display = "Four";
                    break;
                case 5:
                    display = "Five";
                    break;
                case 6:
                    display = "Six";
                    break;
                case 7:
                    display = "Seven";
                    break;
                case 8:
                    display = "Eight";
                    break;
                case 9:
                    display = "Nine";
                    break;
                default:
                    display = "greater than number";
                    break;

            }
            return display;
        }
    }
}
