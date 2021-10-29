namespace CodingAlgorithms.LeetCode.Medium
{
    public class UniqueBST
    {
        public int NumTrees(int n)
        {
            long c = 1;
            for(int i=0; i < n; i++)
            {
                c = c * 2 * (2 * i + 1) / (i+2);
            }

            return (int)c;
        }
    }
}