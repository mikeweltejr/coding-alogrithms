using System;

namespace CodingAlgorithms.LeetCode.Medium
{
    /*

        Find the smallest prime palindrome greater than or equal to N.

        Recall that a number is prime if it's only divisors are 1 and itself, and it is greater than 1. 

        For example, 2,3,5,7,11 and 13 are primes.

        Recall that a number is a palindrome if it reads the same from left to right as it does from right to left. 

        For example, 12321 is a palindrome.

    */
    public class PrimePalindrome
    {
        public int FindPrimePalindrome(int N)
        {
            while(true)
            {
                if(N == Reverse(N) && IsPrime(N))
                    return N;
                N++;
                if (10_000_000 < N && N < 100_000_000)
                    N = 100_000_000;
            }
        }
        
        private int Reverse(int N)
        {
            int ans = 0;
            while(N > 0)
            {
                ans = 10 * ans + (N % 10);
                N /= 10;
            }
            return ans;
        }

        private bool IsPrime(int n)
        {
            if(n < 2) return false;
            if(n == 2) return true;
            int d = (int)Math.Sqrt(n);
            for(int i=2; i<=d; i++)
            {
                if(n % i == 0) return false;
            }
            return true;
        }        
    }
}