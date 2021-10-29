using System;

namespace CodingAlgorithms.LeetCode.Easy
{
    public class ValidPalindrome
    {
        public bool IsValid(string s)
        {
            for(int left=0, right=s.Length - 1; left<right; left++, right--)
            {
                while(left < right && !char.IsLetterOrDigit(s[left]))
                    left++;
                while(left< right && !char.IsLetterOrDigit(s[right]))
                    right--;
                
                if(char.ToLower(s[left]) != char.ToLower(s[right])) return false;
            }

            return true;
        }

        /*
            Given a non-empty string s, you may delete at most one character. 
            Judge whether you can make it a palindrome.        
        */

        public bool IsValid2(string s)
        {
            bool hasRemoved = false;
            for(int left=0, right=s.Length - 1; left<right; left++, right--)
            {
                if(s[left] != s[right] && !hasRemoved)
                {
                    if(s[left] == s[right -1])
                    {
                        s = s.Remove(right, 1);
                        right--;
                    } 
                    else if(s[left+1] == s[right])
                    {
                        s = s.Remove(left, 1);
                        right--;
                    } 
                    hasRemoved = true;
                }

                if(s[left] != s[right]) return false;
            }     

            return true;       
        }
    }
}