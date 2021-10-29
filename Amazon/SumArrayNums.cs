using System.Collections.Generic;

namespace CodingAlgorithms.Amazon
{
    public class SumArrayNums
    {
        public bool TargetFound(int[] nums, int target)
        {
            HashSet<int> h = new HashSet<int>();
            foreach(int i in nums)
            {
                if(h.Contains(target - i))
                    return true;
                h.Add(i);
            }

            return false;
        }

        public int[] FindIndicesOfTarget(int[] nums, int target)
        {
            Dictionary<int, int> h = new Dictionary<int, int>();
            int[] retVals = new int[2];
            for(int i=0; i<nums.Length; i++)
            {
                if(h.ContainsKey(target - nums[i]))
                {
                    retVals[0] = h[target - nums[i]];
                    retVals[1] = i;
                }

                if(!h.ContainsKey(nums[i])) h.Add(nums[i], i);
            }

            return retVals;
        }
    }
}