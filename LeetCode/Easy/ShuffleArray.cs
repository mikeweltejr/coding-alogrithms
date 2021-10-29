namespace CodingAlgorithms.LeetCode.Easy
{
    public class ShuffleArray
    {
        public int[] Shuffle(int[] nums, int n)
        {
            int[] newNums = new int[nums.Length];
            int oddIndex = n;
            int evenIndex = 0;

            for(int i=0; i<nums.Length; i++)
            {
                if(i % 2 == 0)
                {
                    newNums[i] = nums[evenIndex];
                    evenIndex++;
                }
                else
                {
                    newNums[i]  = nums[oddIndex];
                    oddIndex++;
                }
            }

            return newNums;
        }
    }
}