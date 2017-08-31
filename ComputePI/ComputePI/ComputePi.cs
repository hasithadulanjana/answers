using System;

namespace ComputePI
{
    class ComputePi
    {
        public double getPi(double precision)
        {
            double sumOld;
            double sumNew = 0.0;
            long i = 0;
            do
            {
                sumOld = sumNew;
                sumNew += ((i % 2 == 0) ? 1 : -1) * (double)4 / (2 * i + 1);
                ++i;
            } while ((double)Math.Abs(sumNew - sumOld) >= precision);
            Console.WriteLine(sumOld);

           return sumOld;
        }
    }
}
