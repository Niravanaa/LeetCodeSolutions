public class Solution {
    public int LargestSubmatrix(int[][] matrix) {
        int rows = matrix.Length;

        int cols = matrix[0].Length;

        for (int r = 1; r < rows; r++) 
        {
            for (int c = 0; c < cols; c++) 
            {
                if (matrix[r][c] == 1) 
                {
                    matrix[r][c] += matrix[r - 1][c];
                }
            }
        }

        foreach (var row in matrix) 
        {
            Array.Sort(row, (a, b) => b - a);
        }

        int maxArea = 0;
        
        for (int r = 0; r < rows; r++) 
        {
            for (int c = 0; c < cols; c++) 
            {
                maxArea = Math.Max(maxArea, matrix[r][c] * (c + 1));
            }
        }

        return maxArea;
    }
}