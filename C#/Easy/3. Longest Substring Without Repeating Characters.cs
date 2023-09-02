public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int n = s.Length;
        int maxLength = 0;
        int start = 0;
        Dictionary<char, int> charIndexMap = new Dictionary<char, int>();

        for (int end = 0; end < n; end++)
        {
            if (charIndexMap.ContainsKey(s[end]))
            {
                // If the character is already present in the map, update the start pointer
                // to skip the repeating character and make it the new starting point.
                start = Math.Max(start, charIndexMap[s[end]] + 1);
            }

            charIndexMap[s[end]] = end; // Update the character's latest index in the map
            maxLength = Math.Max(maxLength, end - start + 1);
        }

        return maxLength;
    }
}
