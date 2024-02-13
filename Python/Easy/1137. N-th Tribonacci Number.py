class Solution(object):
    def tribonacci(self, n):
        if n == 0:
            return 0
        if n == 1:
            return 1
        
        dp = [0, 1, 1]
        
        for x in range(3, n + 1):
            dp.append(dp[x - 3] + dp[x - 2] + dp[x - 1])
        
        return dp[n]
