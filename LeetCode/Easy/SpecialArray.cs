using System;

namespace CodingAlgorithms.LeetCode.Easy
{
    /*
        You are given an array nums of non-negative integers. 
        nums is considered special if there exists a number x such that there are exactly x numbers 
        in nums that are greater than or equal to x.

        Notice that x does not have to be an element in nums.

        Return x if the array is special, otherwise, return -1. 
        It can be proven that if nums is special, the value for x is unique.    
    */    
    public class SpecialArray
    {
        public int XSpecialArrau(int[] nums)
        {
            Array.Sort(nums);
            int x = nums[nums.Length - 1];
            int length = nums.Length;
            int count = 0;

            if(x == 0) return -1;

            for(int i=length-1; i>=0;i--)
            {
                if(nums[i] >= x)
                {
                    count++;
                }
                else
                {
                    if(x == count) return x;
                    x--;
                    while(x > 0)
                    {
                        if(nums[i] >= x)
                        {
                            count++;
                            break;
                        }

                        if(x == count) return x;
                        x--;
                    }
                }
                Console.WriteLine(count + ":" + x);
                if(count > x) return -1;
            }

            if(x == 0) return -1;

            return x;
        }
    }
}