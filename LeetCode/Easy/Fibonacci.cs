namespace CodingAlgorithms.LeetCode.Easy
{
    public class Fibonacci
    {
        public int Sum(int n)
        {
            if(n == 0) return 0;
            if(n <= 2) return 1;

            return Sum(n-1) + Sum(n-2);
        }
    }
}