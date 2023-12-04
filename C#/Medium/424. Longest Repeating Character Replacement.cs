public class Solution {
    public int CharacterReplacement(string s, int k) {
        int[] charCount = new int[26]; // to count the frequency of each character
        int maxCount = 0; // to keep track of the character with the maximum frequency in the current window
        int maxLength = 0; // to store the length of the longest substring

        int start = 0; // start of the window

        for (int end = 0; end < s.Length; end++) {
            char currentChar = s[end];
            charCount[currentChar - 'A']++; // Increase the count of the current character

            // Update maxCount with the maximum character count in the current window
            maxCount = Math.Max(maxCount, charCount[currentChar - 'A']);

            // Check if the number of replacements needed is greater than k
            // If it is, shrink the window by moving the start pointer
            if (end - start + 1 - maxCount > k) {
                char startChar = s[start];
                charCount[startChar - 'A']--; // Decrease the count of the character going out of the window
                start++; // Move the start pointer to the right

            }
            // Update the maxLength with the current window size
            maxLength = Math.Max(maxLength, end - start + 1);
        }

        return maxLength;
    }
}