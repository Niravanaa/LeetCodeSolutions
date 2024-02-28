class Solution {
    public List<String> getLongestSubsequence(String[] words, int[] groups) {
        List<String> result = new ArrayList<>();

        if (words == null || groups == null || words.length == 0 || groups.length == 0)
        {
            return result;
        }

        int n = words.length;

        int[] dp = new int[n];

        Arrays.fill(dp, 1);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (groups[i] != groups[j])
                {
                    dp[i] = Math.max(dp[i], dp[j] + 1);
                }
            }
        }

        int maxLength = 0;

        for (int length : dp)
        {
            maxLength = Math.max(maxLength, length);
        }

        for (int i = n - 1; i >= 0; i--)
        {
            if (dp[i] == maxLength)
            {
                result.add(words[i]);

                maxLength--;
            }
        }

        Collections.reverse(result);

        return result;
    }
}