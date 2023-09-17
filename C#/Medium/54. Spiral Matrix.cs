public class Solution {
    public IList < int > SpiralOrder(int[][] matrix) {
        IList < int > result = new List < int > ();

        if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
            return result;

        int top = 0, bottom = matrix.Length - 1, left = 0, right = matrix[0].Length - 1;

        while (top <= bottom && left <= right) {
            // Traverse right
            for (int i = left; i <= right; i++)
                result.Add(matrix[top][i]);
            top++;

            // Traverse down
            for (int i = top; i <= bottom; i++)
                result.Add(matrix[i][right]);
            right--;

            // Ensure we haven't crossed boundaries before traversing left and up
            if (top <= bottom) {
                // Traverse left
                for (int i = right; i >= left; i--)
                    result.Add(matrix[bottom][i]);
                bottom--;
            }

            if (left <= right) {
                // Traverse up
                for (int i = bottom; i >= top; i--)
                    result.Add(matrix[i][left]);
                left++;
            }
        }

        return result;
    }

}