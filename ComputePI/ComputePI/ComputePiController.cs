using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputePI
{
    class ComputePiController
    {
        IView view;
        ComputePi computePi;

        public ComputePiController(IView theView, ComputePi theComputePi)
        {
            view = theView;
            computePi = theComputePi;

        }
        
        public void Go()
        {
            view.Start();
            double precision = 0.0000001;
            double pi = computePi.getPi(precision);
            double val = (Math.PI - pi);
            Console.WriteLine( val);
            view.Stop();
        }
    }
}
