using System;

namespace CodingAlgorithms.LeetCode.Medium
{
    public class Medium
    {
        // Given a string s, find the length of the longest substring without repeating characters.
        public int LengthOfLongestSubstring(string s)
        {
            // Keep a temp string
            // Add to string if the character is unique
            // If not save the length of the string as is
            // Clear string out and keep going with the current char
            string temp = "";
            int maxLen = 0;
            for(int i=0; i<s.Length; i++)
            {
                if(temp.Contains(s[i]))
                {
                    maxLen = temp.Length > maxLen ? temp.Length : maxLen;
                    int charIndex = temp.IndexOf(s[i]);
                    if(charIndex == temp.Length - 1) 
                        temp = s[i].ToString();
                    else
                        temp = temp.Substring(charIndex + 1) + s[i].ToString();
                }
                else
                {
                    temp += s[i].ToString();
                    maxLen = temp.Length > maxLen ? temp.Length : maxLen;
                }
            }

            return maxLen;
        }
    }
}