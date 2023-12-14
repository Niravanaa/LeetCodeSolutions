public class Solution {
    public int NumSpecial(int[][] mat) {
        int width = mat.Length;
        int height = mat[0].Length;
        int[] rowCount = new int[width];
        int[] colCount = new int[height];
        int result = 0;

        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                rowCount[i] += mat[i][j];
                colCount[j] += mat[i][j];
            }
        }

        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                if (rowCount[i] == 1 && colCount[j] == 1 && mat[i][j] == 1)
                {
                    result++;
                }
            }
        }

        return result;
    }
}