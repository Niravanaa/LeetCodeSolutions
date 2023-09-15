public class Solution {
    public string MinWindow(string s, string t) {
        // Create a dictionary to store the character frequencies of the target string t.
        Dictionary<char, int> targetFreq = new Dictionary<char, int>();
        
        // Initialize the targetFreq dictionary with character frequencies from t.
        foreach (char c in t) {
            if (targetFreq.ContainsKey(c)) {
                targetFreq[c]++;
            } else {
                targetFreq[c] = 1;
            }
        }
        
        // Create two pointers to represent the sliding window.
        int left = 0; // Left pointer
        int minLen = int.MaxValue; // Initialize minLen with a large value.
        int minLeft = 0; // Store the starting index of the minimum window.
        int count = t.Length; // Counter to track how many characters are remaining to be matched.
        
        // Loop through the string s using the right pointer.
        for (int right = 0; right < s.Length; right++) {
            // If the current character exists in the targetFreq dictionary, decrement its count.
            if (targetFreq.ContainsKey(s[right])) {
                targetFreq[s[right]]--;
                // If the character count becomes zero or negative, decrement the count variable.
                if (targetFreq[s[right]] >= 0) {
                    count--;
                }
            }
            
            // When all characters in t are matched, try to minimize the window size.
            while (count == 0) {
                // Update the minimum window if the current window is smaller.
                if (right - left + 1 < minLen) {
                    minLen = right - left + 1;
                    minLeft = left;
                }
                
                // Move the left pointer to the right to find a smaller window.
                if (targetFreq.ContainsKey(s[left])) {
                    targetFreq[s[left]]++;
                    // If the character count becomes positive, increment the count variable.
                    if (targetFreq[s[left]] > 0) {
                        count++;
                    }
                }
                
                left++; // Move the left pointer to the right.
            }
        }
        
        // If no valid window is found, return an empty string.
        if (minLen == int.MaxValue) {
            return "";
        }
        
        // Extract and return the minimum window substring from s.
        return s.Substring(minLeft, minLen);
    }
}
