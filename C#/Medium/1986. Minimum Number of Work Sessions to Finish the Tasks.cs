public class Solution {
    public int MinSessions(int[] tasks, int sessionTime) {
        int n = tasks.Length;
        int[] dp = new int[1 << n]; // Dynamic programming array to store minimum sessions for each state

        for (int i = 1; i < (1 << n); i++) {
            int total = 0;
            for (int j = 0; j < n; j++) {
                if ((i & (1 << j)) != 0) {
                    total += tasks[j];
                }
            }
            if (total <= sessionTime) {
                dp[i] = 1;
                continue;
            }

            dp[i] = int.MaxValue;

            for (int sub = i; sub > 0; sub = (sub - 1) & i) {
                if (dp[sub] > 0 && dp[i - sub] > 0) {
                    dp[i] = Math.Min(dp[i], dp[sub] + dp[i - sub]);
                }
            }
        }

        return dp[(1 << n) - 1];
    }
}
