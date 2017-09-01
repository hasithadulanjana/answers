using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class FibController
    {
        IView view;
        FibonacciModel fib;

        public FibController(IView theView, FibonacciModel theFibModel)
        {
            view = theView;
            fib = theFibModel;
        }

        public void Runner()
        {
           
            view.Start();
            
            long val= fib.printFib(3);
            view.Message(val);
            
            view.Stop();
        }
    }
}
