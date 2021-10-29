namespace CodingAlgorithms.LeetCode.Easy
{
    public class Easy
    {
        public int Tribonacci(int n)
        {
            // n = Fn-1 + Fn-2 + Fn-3
            // ex: n=8 = 2 + 4 + 7 = 13
            if (n < 3) return n==0 ? 0 : 1;

            // This is very time consuming to do recursively - but works
            // return (Tribonacci(n-3) + Tribonacci(n-2) + Tribonacci(n-1));

            // temp will hold the current sum of xyz, x is n-3, y is n-2, z is n-1
            int temp, x=0, y=1, z=1;
            for(int i=3; i<=n; i++)
            {
                temp = x + y + z;
                x = y;
                y = z;
                z = temp;
            }
            return z;
        }
    }
}