using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingAlgorithms.LeetCode.Easy
{
    /*
        Given an array of integers arr, replace each element with its rank.

        The rank represents how large the element is. The rank has the following rules:

        Rank is an integer starting from 1.
        The larger the element, the larger the rank. If two elements are equal, their rank must be the same.
        Rank should be as small as possible.    
    */
    public class RankTransformArray
    {
        public int[] TransformArray(int[] arr)
        {
            Dictionary<int, List<int>> indexHolder = new Dictionary<int, List<int>>();

            for(int i=0; i<arr.Length; i++)
            {
                if(indexHolder.ContainsKey(arr[i]))
                {
                    var tempList = indexHolder[arr[i]];
                    tempList.Add(i);
                    indexHolder[arr[i]] = tempList;
                }
                else
                {
                    indexHolder[arr[i]] = new List<int> {i};
                }

                var temp = indexHolder[arr[i]];
            }

            int rank = 0;
            int curInt = -1;
            Array.Sort(arr);
            int[] results = new int[arr.Length];
            
            for(int i=0; i<arr.Length; i++)
            {
                if(curInt != arr[i])
                {
                    curInt = arr[i];
                    rank++;
                }

                var tempList = indexHolder[curInt];
                int index = tempList.FirstOrDefault();
                tempList.Remove(index);
                indexHolder[curInt] = tempList;

                results[index] = rank;
            }

            return results;
        }
    }
}