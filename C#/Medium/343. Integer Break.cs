public class Solution {
    public int IntegerBreak(int n) {
        // Handle base cases
        if (n == 2) {
            return 1;
        }

        if (n == 3) {
            return 2;
        }

        int[] dp = new int[n + 1];
        dp[0] = 0;
        dp[1] = 1;
        dp[2] = 2;
        dp[3] = 3;

        for (int i = 4; i <= n; i++) {
            int maxProduct = 0;
            for (int j = 1; j <= i / 2; j++) {
                int product = dp[j] * dp[i - j];
                maxProduct = Math.Max(maxProduct, product);
            }
            dp[i] = maxProduct;
        }

        return dp[n];
    }
}