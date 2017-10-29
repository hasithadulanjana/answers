using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    interface IView
    {
        void Say<T>(T message);
        string Get();
        void Wait();


    }
}
