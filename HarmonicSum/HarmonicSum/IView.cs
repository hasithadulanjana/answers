using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonicSum
{
    interface IView
    {
        void Start();
        void Stop();
        string GetString(string prompt);
        Int32 GetInt(string prompt);

        void Show<T>(T message);
    }
}
