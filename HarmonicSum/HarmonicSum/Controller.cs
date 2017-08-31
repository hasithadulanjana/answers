using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonicSum
{
    class Controller
    {
        IView view;
        Model model;

        public Controller(IView theView, Model theModel)
        {
            view = theView;
            model = theModel;
        }

        public void Go()
        {
            view.Start();
            int n = view.GetInt("Please Enter the Value?");
            double sumL2R = model.printRightToLeftSum(n);
            Console.WriteLine(sumL2R);
            double sumR2L = model.printLeftToRightSum(n);
            Console.WriteLine(sumR2L);
            double answer = sumL2R - sumR2L;
            view.Show(answer);
            view.Stop();
        }
    }
}
