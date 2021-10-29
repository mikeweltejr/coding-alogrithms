using System;

namespace CodingAlgorithms.LeetCode.Medium
{
    /*
        Given an array nums and two types of queries where you should update the value of an index in the array, 
        and retrieve the sum of a range in the array.

        Implement the NumArray class:

        NumArray(int[] nums) 
            - Initializes the object with the integer array nums.
        void update(int index, int val) 
             - Updates the value of nums[index] to be val.
        int sumRange(int left, int right) 
            - Returns the sum of the subarray nums[left, right] (i.e., nums[left] + nums[left + 1], ..., nums[right]).    
    */
    public class NumArray
    {
        private int[] numArray;
        private int[] b;
        private int length;

        public NumArray(int[] nums)
        {
            numArray = nums;
            var l = Math.Sqrt(numArray.Length);
            length = (int)Math.Ceiling(numArray.Length/l);
            b = new int[length];
            
            for(int i=0; i<numArray.Length; i++)
            {
                b[i/length] += nums[i];
            }
        }

        public void Update(int index, int val)
        {
            int b_l = index / length;
            b[b_l] = b[b_l] - numArray[index] + val;
            numArray[index] = val;
        }

        public int SumRange(int left, int right)
        {
            int sum = 0;
            int startBlock = left / length;
            int endBlock = right / length;

            if(startBlock == endBlock)
            {
                for(int k=left; k<=right; k++) sum += numArray[k];
            }
            else
            {
                for (int k = left; k <= (startBlock + 1) * length - 1; k++)
                    sum += numArray[k];
                for (int k = startBlock + 1; k <= endBlock - 1; k++)
                    sum += b[k];
                for (int k = endBlock * length; k <= right; k++)
                    sum += numArray[k];
            }

            return sum;
        }
    }
}