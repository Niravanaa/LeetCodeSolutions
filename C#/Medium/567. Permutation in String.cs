using System;
using System.Collections.Generic;

public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length) {
            return false;
        }
        
        // Create character count dictionaries for s1 and a sliding window in s2
        Dictionary<char, int> s1Count = new Dictionary<char, int>();
        Dictionary<char, int> windowCount = new Dictionary<char, int>();
        
        // Initialize s1Count with character frequencies in s1
        foreach (char c in s1) {
            if (s1Count.ContainsKey(c)) {
                s1Count[c]++;
            } else {
                s1Count[c] = 1;
            }
        }
        
        int left = 0; // Left pointer of the sliding window
        int right = 0; // Right pointer of the sliding window
        
        while (right < s2.Length) {
            char rightChar = s2[right];
            
            // Add the character at the right end of the window to windowCount
            if (windowCount.ContainsKey(rightChar)) {
                windowCount[rightChar]++;
            } else {
                windowCount[rightChar] = 1;
            }
            
            // If the window size is equal to s1's length
            if (right - left + 1 == s1.Length) {
                // Check if the windowCount is a permutation of s1Count
                if (IsPermutation(windowCount, s1Count)) {
                    return true;
                }
                
                // Move the left pointer to the right by 1 step
                char leftChar = s2[left];
                windowCount[leftChar]--;
                if (windowCount[leftChar] == 0) {
                    windowCount.Remove(leftChar);
                }
                left++;
            }
            
            right++;
        }
        
        return false;
    }
    
    // Helper function to check if two dictionaries are permutations of each other
    private bool IsPermutation(Dictionary<char, int> dict1, Dictionary<char, int> dict2) {
        if (dict1.Count != dict2.Count) {
            return false;
        }
        
        foreach (var kvp in dict1) {
            char key = kvp.Key;
            int value = kvp.Value;
            if (!dict2.ContainsKey(key) || dict2[key] != value) {
                return false;
            }
        }
        
        return true;
    }
}
