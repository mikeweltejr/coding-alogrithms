using System;

namespace CodingAlgorithms.LeetCode.Medium
{
    /*
        Given an array of integers arr of even length n and an integer k.

        We want to divide the array into exactly n / 2 pairs such that the sum of each pair is divisible by k.

        Return True If you can find a way to do that or False otherwise.    
    */
    public class ArrayPairsDivisible
    {
        public bool PairFound(int[] nums, int k)
        {
            int[] firstHalf;
            int[] secondHalf;
            int halfLength = nums.Length / 2;
            firstHalf = new int[halfLength];
            secondHalf = new int[nums.Length - halfLength];
            int index = 0;

            for(int i=0; i<nums.Length; i++)
            {
                if(i < halfLength) firstHalf[i] = nums[i];
                if(i >= halfLength)
                {
                    secondHalf[index] = nums[i];
                    index++;
                }
            } 

            int right = secondHalf.Length - 1;
            for(int i=0; i<firstHalf.Length; i++)
            {
                Console.WriteLine($"firstHalf[i]: {firstHalf[i]}, secondHalf[right]: {secondHalf[right]}");
                if((firstHalf[i] + secondHalf[right]) % k == 0) return true;
                right--;
            }

            return false;
        }
    }
}