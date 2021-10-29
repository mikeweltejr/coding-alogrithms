namespace CodingAlgorithms.LeetCode.Easy
{
    public class PerfectNumber
    {
        public bool CheckPerfectNumber(int num)
        {
            if(num <= 5 && num >= 0) return false;
            int sum = 1;
            bool isEven = num % 2 == 0;

            for(int i=2; i<num; i++)
            {
                if(num % i == 0)
                {
                    sum += i;
                    if(isEven && num / i == 2) break;
                    if(!isEven && num / i == 3) break;
                }
                if(sum > num) return false;    
            }
            
            if(sum == num) return true;
            return false;
        }
    }
}