public class Solution {
  public double SoupServings(int n) {
    if (n >= 5000)
      return 1.0;

    n = (n + 24) / 25; // Convert n to units of 25 ml (rounding up).

    double[, ] dp = new double[n + 1, n + 1];

    for (int i = 0; i <= n; i++) {
      for (int j = 0; j <= n; j++) {
        if (i == 0 && j == 0)
          dp[i, j] = 0.5;
        else if (i == 0)
          dp[i, j] = 1.0;
        else if (j == 0)
          dp[i, j] = 0.0;
        else {
          dp[i, j] = 0.25 * (
            dp[Math.Max(i - 4, 0), j] +
            dp[Math.Max(i - 3, 0), Math.Max(j - 1, 0)] +
            dp[Math.Max(i - 2, 0), Math.Max(j - 2, 0)] +
            dp[Math.Max(i - 1, 0), Math.Max(j - 3, 0)]
          );
        }
      }
    }

    return dp[n, n];
  }

}