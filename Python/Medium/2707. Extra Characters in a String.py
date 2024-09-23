class Solution:
    def minExtraChar(self, s: str, dictionary: List[str]) -> int:
        n = len(s)

        dp = [n] * (n + 1)

        dp[0] = 0

        word_set = set(dictionary)

        for i in range(n):
            if dp[i] == n:
                continue

            for j in range(i + 1, n + 1):
                if s[i:j] in word_set:
                    dp[j] = min(dp[j], dp[i])

            dp[i + 1] = min(dp[i + 1], dp[i] + 1)

        return dp[n]