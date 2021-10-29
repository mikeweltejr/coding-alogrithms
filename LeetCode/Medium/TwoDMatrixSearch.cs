namespace CodingAlgorithms.LeetCode.Medium
{
    /*
        Write an efficient algorithm that searches for a value in an m x n matrix. This matrix has the following properties:

        Integers in each row are sorted from left to right.
        The first integer of each row is greater than the last integer of the previous row.
    */
    public class TwoDMatrixSearch
    {
        public bool SearchMatrix(int[,] matrix, int target) {
            int row = 0;
            while(row < matrix.GetLength(0))
            {
                if(target > matrix[row,matrix.GetLength(1)-1])
                {
                    row++;
                }
                else
                {
                int middle = matrix.GetLength(0) / 2;
                
                    if(target == matrix[row,middle]) return true;

                    if(target < matrix[row,middle] && middle > 0)
                    {
                        middle--;

                        while(middle >= 0)
                        {
                            if(target == matrix[row,middle]) return true;
                            middle--;
                        }
                        return false;
                    }

                    if(target > matrix[row,middle] && middle < matrix.GetLength(1)-1)
                    {
                        middle++;
                        while(middle < matrix.GetLength(1)-1)
                        {
                            if(target == matrix[row,middle]) return true;
                            middle++;
                        }  
                        return false;
                    }   
                    row++;
                }
            }
            
            return false;
        }        
    }
}