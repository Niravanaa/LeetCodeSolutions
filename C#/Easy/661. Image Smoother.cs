public class Solution 
{
    public int[][] ImageSmoother(int[][] img) 
    {
        int m = img.Length;

        int n = img[0].Length;

        int[][] result = new int[m][];

        for (int i = 0; i < m; i++) 
        {
            result[i] = new int[n];

            for (int j = 0; j < n; j++) 
            {
                int sum = 0;

                int count = 0;

                for (int x = Math.Max(0, i - 1); x <= Math.Min(m - 1, i + 1); x++) 
                {
                    for (int y = Math.Max(0, j - 1); y <= Math.Min(n - 1, j + 1); y++) 
                    {
                        sum += img[x][y];

                        count++;
                    }
                }

                result[i][j] = sum / count;
            }
        }

        return result;
    }
}