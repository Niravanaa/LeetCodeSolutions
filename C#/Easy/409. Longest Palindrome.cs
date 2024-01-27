public class Solution {
    public int LongestPalindrome(string s) {
        Dictionary<char, int> charDict = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (!charDict.ContainsKey(s[i]))
            {
                charDict.Add(s[i], 0);
            }

            charDict[s[i]]++;
        }

        int result = 0;
        bool singleAdded = false;

        foreach (char letter in charDict.Keys)
        {
            if (charDict[letter] % 2 == 0)
            {
                result += charDict[letter];
            }
            else
            {
                result += charDict[letter] - 1;
                singleAdded = true;
            }
        }

        if (singleAdded)
        {
            result++;
        }

        return result;
    }
}
