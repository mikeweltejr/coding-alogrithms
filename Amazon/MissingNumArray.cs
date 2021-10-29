namespace CodingAlgorithms.Amazon
{
    public class MissingNumArray
    {
        public int Calculate1ToN(int[] n)
        {
            int sum = 0;
            foreach(int i in n) sum += i;
            // missing one number so add 1 to the length
            int len = n.Length + 1;

            int actualSum = (len * (len + 1)) / 2;
            return actualSum - sum;
        }

        public int Calculate0ToN(int[] n)
        {
            int sum = 0;
            foreach(int i in n) sum+=i;

            int actualSum = (n.Length * (n.Length + 1)) / 2;

            return actualSum - sum;
        }
    }
}