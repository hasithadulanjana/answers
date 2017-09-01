using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    interface IView
    {
        void Start();
        void Stop();
        string GetString(string prompt);
        void Message<T>(T message );
    }
}
