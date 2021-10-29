using System;

namespace CodingAlgorithms.LeetCode.Medium
{
    public class LongestPalindrome
    {
        public string LengthOfLongestPalindrome(string s)
        {

            string temp = "";
            string longestPalindrome = s[0].ToString();

            for(int i=0; i<s.Length; i++)
            {
                if(longestPalindrome.Length >= s.Length - i) return longestPalindrome;
                temp = s[i].ToString();
                for(int j=i+1; j<s.Length; j++)
                {
                    temp += s[j].ToString();
                    if(temp.Length > longestPalindrome.Length && IsPalindrome(temp))
                        longestPalindrome = temp;
                }
            }

            return longestPalindrome;
        }

        public bool IsPalindrome(string s)
        {
            if (s.Length < 2) return true;
            for(int i=0; i<s.Length; i++)
            {
                if(s[i] != s[s.Length - i - 1]) return false;
                
            }
            return true;
        }
    }
}