public class Solution {
    public string LongestPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s) || s.Length == 1)
            return s;

        int start = 0;
        int maxLength = 1;
        int n = s.Length;
        bool[,] dp = new bool[n, n];

        // All substrings of length 1 are palindromes
        for (int i = 0; i < n; i++)
        {
            dp[i, i] = true;
        }

        // Check for substrings of length 2
        for (int i = 0; i < n - 1; i++)
        {
            if (s[i] == s[i + 1])
            {
                dp[i, i + 1] = true;
                start = i;
                maxLength = 2;
            }
        }

        // Check for substrings of length 3 or more
        for (int len = 3; len <= n; len++)
        {
            for (int i = 0; i < n - len + 1; i++)
            {
                int j = i + len - 1;

                if (s[i] == s[j] && dp[i + 1, j - 1])
                {
                    dp[i, j] = true;

                    if (len > maxLength)
                    {
                        start = i;
                        maxLength = len;
                    }
                }
            }
        }

        return s.Substring(start, maxLength);
    }
}