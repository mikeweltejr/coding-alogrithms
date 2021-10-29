using System;

namespace CodingAlgorithms.LeetCode.Hard
{
    public class PasswordChecker
    {
        public int StrongPasswordChecker(string pword)
        {
            //"aa123"
            int upperViolation = 1;
            int lowerViolation = 1;
            int digitViolation  = 1;
            int repeatViolation = 0;
            int size = pword.Length > 20 ? 20 : pword.Length;
            int steps = 0;
            
            int repeatCount = 1;
            char prev;
            for(int i=0; i<size; i++)
            {
                char c = pword[i];
                if(i > 0)
                {
                    prev = pword[i-1];
                    if(c == prev)
                        repeatCount++;
                    else
                        repeatCount = 1;
                }

                if(char.IsUpper(c)) 
                    upperViolation = 0;
                else if(char.IsLower(c))
                    lowerViolation = 0;
                else if(char.IsDigit(c))
                    digitViolation = 0;

                if(repeatCount == 3)
                {
                    repeatCount = 0;
                    repeatViolation++;
                } 
            }

            Console.WriteLine(lowerViolation);

            if(pword.Length < 6) 
                steps = 6 - pword.Length;
            if(pword.Length > 20)
                steps = 20 - pword.Length;
            
            if(upperViolation + lowerViolation + digitViolation + repeatViolation == steps) return steps;
            if(steps == 0)
            {
                if(repeatViolation > 0) return repeatViolation;
                else
                    return (upperViolation + lowerViolation + digitViolation);
            }
            else if(steps < 0)
            {
                return(repeatViolation + lowerViolation + digitViolation + upperViolation + Math.Abs(steps));
            }
            
            return steps;
        }
    }
}