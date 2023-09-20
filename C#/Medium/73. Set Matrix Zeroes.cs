public class Solution {
    public void SetZeroes(int[][] matrix) {
        // Check if the matrix is empty or null
        if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0) {
            return; // Nothing to do if the matrix is empty
        }

        int m = matrix.Length;    // Number of rows
        int n = matrix[0].Length; // Number of columns

        // Step 1: Identify the rows and columns to be zeroed
        bool zeroFirstRow = false;
        bool zeroFirstCol = false;

        // Check if the first row should be zeroed
        for (int i = 0; i < n; i++) {
            if (matrix[0][i] == 0) {
                zeroFirstRow = true;
                break;
            }
        }

        // Check if the first column should be zeroed
        for (int i = 0; i < m; i++) {
            if (matrix[i][0] == 0) {
                zeroFirstCol = true;
                break;
            }
        }

        // Step 2: Use the first row and first column to mark zeroed rows and columns
        for (int i = 1; i < m; i++) {
            for (int j = 1; j < n; j++) {
                if (matrix[i][j] == 0) {
                    matrix[i][0] = 0; // Mark the corresponding row
                    matrix[0][j] = 0; // Mark the corresponding column
                }
            }
        }

        // Step 3: Set zero for marked rows and columns
        for (int i = 1; i < m; i++) {
            for (int j = 1; j < n; j++) {
                if (matrix[i][0] == 0 || matrix[0][j] == 0) {
                    matrix[i][j] = 0; // Set the element to zero
                }
            }
        }

        // Step 4: Set zero for the first row and first column if needed
        if (zeroFirstRow) {
            for (int i = 0; i < n; i++) {
                matrix[0][i] = 0;
            }
        }

        if (zeroFirstCol) {
            for (int i = 0; i < m; i++) {
                matrix[i][0] = 0;
            }
        }
    }
}
