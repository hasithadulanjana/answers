using System;

namespace Test
{
     class Model
    {
        public String CheckMark(int mark)
        {
            String result;
            if(mark >= 50)
            {
                result = "Pass";
            }
            else
            {
                result = "Failure";
            }

            return result;
        }
    }
}