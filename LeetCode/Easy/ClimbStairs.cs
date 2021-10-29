namespace CodingAlgorithms.LeetCode.Easy
{
    /*
        You are climbing a staircase. It takes n steps to reach the top.

        Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?    
    */
    public class ClimbStairs
    {
        public int Calculate(int n)
        {
            if (n >= 0 && n <= 2) return n;
            int[] dp = new int[n + 1];
            dp[1] = 1;
            dp[2] = 2;
            for(int i=3; i<=n; i++)
            {
                dp[i] = dp[i-1] + dp[i-2];
            }

            return dp[n];
        }
    }
}