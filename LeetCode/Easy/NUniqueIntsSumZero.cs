namespace CodingAlgorithms.LeetCode.Easy
{
    public class NUniqueIntsSumZero
    {
        // Given an integer n, return any array containing n unique integers such that they add up to 0.
        public int[] SumZero(int n)
        {
            int[] nums = new int[n];
            bool isEven = n % 2 == 0;
            int half = n / 2;
            int curInt = half;

            if(n == 1) return new int[1] { 0 };

            for(int i=0; i<n; i++)
            {
                if(isEven && curInt == 0) curInt++;

                if(i < half)
                {
                    nums[i] = curInt * -1;
                    curInt--;
                }
                if(i >= half)
                {
                    nums[i] = curInt;
                    curInt++;
                }
            }

            return nums;
        }
    }
}