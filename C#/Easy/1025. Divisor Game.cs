public class Solution {
    public bool DivisorGame(int n) {
        bool[] dp = new bool[n + 1];

        dp[1] = false;

        for (int i = 2; i <= n; i++)
        {
            dp[i] = false;

            for (int j = 1; j < i; j++)
            {
                if (i % j == 0 && !dp[i - j])
                {
                    dp[i] = true;

                    break;
                }
            }
        }

        return dp[n];
    }
}