using System;

namespace CodingAlgorithms.LeetCode.Easy
{
    public class SubtractProductAndSum
    {
        public int Calculate(int num)
        {
            var s = num.ToString().ToCharArray();
            int product = 1;
            int sum = 0;
            for(int i=0; i<s.Length; i++)
            {
                product = product * Convert.ToInt32(s[i].ToString());
                sum = sum + Convert.ToInt32(s[i].ToString());
            }
            
            return product - sum;
            }
    }
}