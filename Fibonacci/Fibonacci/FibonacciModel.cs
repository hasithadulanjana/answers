namespace Fibonacci
{
    public class FibonacciModel
    {
        
        public long printFib(int n)
        {
            long fb1 = 1;
            long fb2 = 2;
            long fbn = 0;
            long sum = 0;
            
            if(n <= 0)
            {

              
            }
            for (int i = 1; i <= n; i++)
            {
                switch (i)
                {
                    case 1: fbn = fb1; break;
                    case 2: fbn = fb2; break;
                    default:
                        fbn = fb1 + fb2;
                        fb1 = fb2;
                        fb2 = fbn;
                        break;
                }
                sum += fbn;
                

            }
            return sum;
        }
    }
}