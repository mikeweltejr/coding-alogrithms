using System;

namespace CodingAlgorithms.LeetCode.Easy
{
    public class PlusOne
    {
        public int[] Solve(int[] nums)
        {
            int size = nums.Length - 1;
            if(nums[size] < 9)
            {
                nums[size] = nums[size] + 1;
                return nums;
            }
            
            int[] plusOneArr = new int[nums.Length + 1];
            while(nums[size] == 9)
            {
                nums[size] = 0;
                plusOneArr[size+1] = 0;

                if(size == 0)
                {
                    plusOneArr[0] = 1;
                    return plusOneArr;
                }

                size--;
            }

            nums[size] = nums[size] + 1;
            return nums;
        }

        public void Diplsay(int[] nums)
        {
            foreach(int i in nums)
                Console.Write(i);
            Console.WriteLine();
        }
    }
}