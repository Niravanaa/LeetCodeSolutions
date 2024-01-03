public class Solution {
    public int MinIncrements(int n, int[] cost) 
    {
        int result = 0;

        int[] sum = new int[n];

        for (int i = n - 1; i >= 0; i--)
        {
            sum[i] = cost[i];

            if (i * 2 + 1 < n)
            {
                sum[i] += Math.Max(sum[i * 2 + 1], sum[i * 2 + 2]);
            }
        }

        for (int i = 0; i < n; i++)
        {
            if (i * 2 + 1 < n)
            {
                result += Math.Abs(sum[i * 2 + 1] - sum[i * 2 + 2]);
            }
        }

        return result;
    }
}