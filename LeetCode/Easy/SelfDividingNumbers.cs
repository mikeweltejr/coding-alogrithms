using System;
using System.Collections.Generic;

namespace CodingAlgorithms.LeetCode.Easy
{
    /*
        A self-dividing number is a number that is divisible by every digit it contains.

        For example, 128 is a self-dividing number because 128 % 1 == 0, 128 % 2 == 0, and 128 % 8 == 0.

        Also, a self-dividing number is not allowed to contain the digit zero.

        Given a lower and upper number bound, output a list of every possible self dividing number, including the bounds if possible.

        Example 1:
        Input: 
        left = 1, right = 22
        Output: [1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 15, 22]
    */
    public class SelfDividingNumbers
    {
        public List<int> FindSelfDividingNumbers(int left, int right)
        {
            var retList = new List<int>();

            for(int i=left; i<=right; i++)
            {
                if(i<10 && i>0)
                {
                    retList.Add(i);
                    continue;
                }
                if(!i.ToString().Contains("0"))
                {
                    int j=0;
                    bool addNum = true;
                    var s = i.ToString().ToCharArray();
                    while(j<i.ToString().Length)
                    {
                        int temp = Convert.ToInt32((s[j].ToString()));
                        if(i % temp != 0)
                        {
                            Console.WriteLine(i + ":" + temp);
                            addNum = false;
                            break;
                        }
                        j++;
                    }
                    if(addNum) retList.Add(i);
                }

            }

            return retList;
        }
    }
}