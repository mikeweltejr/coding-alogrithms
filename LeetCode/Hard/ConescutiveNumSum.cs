using System;

namespace CodingAlgorithms.LeetCode.Hard
{
    public class ConsecutiveNumSum
    {
        public int Calculate(int n)
        {
            int count = 0; 
            int upperLimit = (int)(Math.Sqrt(2 * n + .25) - .5);

            for(int k=1; k<=upperLimit; k++)
            {
                if((n - k * (k+1) / 2) % k == 0)
                    count++;
            }

            return count;
        }

        public int Calculate2(int n)
        {
            int count=0;
            int upperLimit = (int)(Math.Sqrt(2 * n + .25) - .5);

            for(int k=1; k<=upperLimit; k++)
            {
                n -= k;
                if(n % k == 0) count++;
            }

            return count;
        }
    }
}