public class Solution {
    public int[][] OnesMinusZeros(int[][] grid) {
        int m = grid.Length;
        int n = grid[0].Length;

        int[] onesRow = new int[m];
        int[] onesCol = new int[n];
        int[] zeroesRow = new int[m];
        int[] zeroesCol = new int[n];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (grid[i][j] == 1)
                {
                    onesRow[i]++;
                    onesCol[j]++;
                }
                else
                {
                    zeroesRow[i]++;
                    zeroesCol[j]++;
                }
            }
        }

        int[][] diffGrid = new int[m][];

        for (int i = 0; i < m; i++)
        {
            diffGrid[i] = new int[n];

            for (int j = 0; j < n; j++)
            {
                diffGrid[i][j] = onesRow[i] + onesCol[j] - zeroesRow[i] - zeroesCol[j];
            }
        }

        return diffGrid;
    }
}