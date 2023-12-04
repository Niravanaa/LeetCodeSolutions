public class Solution {
    private int[][] moves = new int[][] 
    {
        new int[] { 4, 6 },
        new int[] { 6, 8 },
        new int[] { 7, 9 },
        new int[] { 4, 8 },
        new int[] { 0, 3, 9 },
        new int[] {},
        new int[] { 0, 1, 7 },
        new int[] { 2, 6 },
        new int[] { 1, 3 },
        new int[] { 2, 4 }
    };
    
    public int KnightDialer(int n) 
    {
        const int MOD = 1000000007;

        long[,] dp = new long[n + 1, 10];

        for (int i = 0; i < 10; i++) dp[1, i] = 1;

        for (int i = 2; i <= n; i++)
        {
            for (int j = 0; j < 10; j++) 
            {
                foreach (int next in moves[j]) 
                {
                    dp[i, j] = (dp[i, j] + dp[i - 1, next]) % MOD;
                }
            }
        }

        long total = 0;

        for (int i = 0; i < 10; i++) 
        {
            total = (total + dp[n, i]) % MOD;
        }

        return (int)total;
    }
}