class Solution {
    public int[][] largestLocal(int[][] grid) {
        int n = grid.length;
        // Create a new 2D array to store the results, with dimensions (n - 2) x (n - 2)
        int[][] maxLocal = new int[n - 2][n - 2];

        // Loop through the grid, excluding the last two rows and columns
        for (int i = 0; i < n - 2; i++) {
            for (int j = 0; j < n - 2; j++) {
                // Initialize max to the smallest possible integer value
                int max = Integer.MIN_VALUE;
                // Iterate over the 3x3 sub-matrix centered at position (i+1, j+1)
                for (int x = i; x < i + 3; x++) {
                    for (int y = j; y < j + 3; y++) {
                        // Update max with the maximum value found in the sub-matrix
                        max = Math.max(max, grid[x][y]);
                    }
                }
                // Store the maximum value found in the sub-matrix in maxLocal array
                maxLocal[i][j] = max;
            }
        }

        // Return the resulting 2D array
        return maxLocal;
    }
}
