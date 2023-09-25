public class Solution {
    public char FindTheDifference(string s, string t) {
        // Calculate the character frequency in s and t
        int[] charCount = new int[26]; // Assuming lowercase English letters

        foreach (char c in s) {
            charCount[c - 'a']++;
        }

        foreach (char c in t) {
            charCount[c - 'a']--;
        }

        // Find the differing character
        for (int i = 0; i < charCount.Length; i++) {
            if (charCount[i] < 0) {
                return (char)('a' + i);
            }
        }

        // If no difference found, return a default character (or handle it as needed)
        return ' ';
    }
}
