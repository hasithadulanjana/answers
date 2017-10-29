namespace Test
{
    class ExNineModel
    {
        public int getNumbers(int target)
        {
            int start = 1;
            int sum = 0;
            int sevDiv = 0;
            for(int i = start; i <= target;i++)
            {
                sum = i + 1;

                if(sum/7!= 0)
                {
                    sevDiv += sum;
                }
            }
            return sevDiv;
        }
    }
}
