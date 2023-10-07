public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int arrayNumber = -1;

        for (int i = 0; i < matrix.Length; i++)
        {
            if (matrix[i][matrix[i].Length - 1] >= target)
            {
                arrayNumber = i;

                break;
            }
        }

        if (arrayNumber == -1)
        {
            return false;
        }

        for (int i = 0; i < matrix[arrayNumber].Length; i++)
        {
            if (matrix[arrayNumber][i] == target)
            {
                return true;
            }
        }

        return false;
    }
}