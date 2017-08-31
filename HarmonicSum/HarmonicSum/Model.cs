namespace HarmonicSum
{
    public class Model
    {
        public double printLeftToRightSum(int n)
        {
            double sum = 0.0;
            for(int i =1; i <=n; i++)
            {
                sum += (double)1 / i;
            }
            return sum;
        }

        public double printRightToLeftSum(int n)
        {
            double sum = 0.0;
            for(int i = n; i >= 1; i--)
            {
                sum += (double)1 / i;

            }
            return sum;
        }
    }
}