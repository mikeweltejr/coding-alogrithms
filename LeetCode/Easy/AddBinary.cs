using System;

namespace CodingAlgorithms.LeetCode.Easy
{
    public class AddBinary
    {
        public string Solve(string a, string b)
        {
            int maxLen = a.Length > b.Length ? a.Length : b.Length;
            if(a.Length < maxLen) a = a.PadLeft(maxLen, Convert.ToChar("0"));
            if(b.Length < maxLen) b = b.PadLeft(maxLen, Convert.ToChar("0"));

            string retStr = "";
            int carry = 0;
            for(int i=maxLen-1; i>=0; i--)
            {
                int sum = Convert.ToInt32(a[i].ToString()) + Convert.ToInt32(b[i].ToString()) + carry;
                if(sum > 1)
                {
                    carry = 1;
                    sum = sum - 2;
                } 
                else
                    carry = 0;

                retStr = retStr.Insert(0, sum.ToString());
                if (i == 0 && carry == 1) retStr = retStr.Insert(0, "1");
            }

            return retStr;
        }
    }
}