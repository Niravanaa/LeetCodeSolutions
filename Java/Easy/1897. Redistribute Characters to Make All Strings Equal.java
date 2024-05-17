import java.util.HashMap;
import java.util.Map;

class Solution {
    public boolean makeEqual(String[] words) {
        // Create a map to count the frequency of each character
        Map<Character, Integer> charCount = new HashMap<>();
        
        // Iterate over each word in the array
        for (String word : words) {
            // Iterate over each character in the word
            for (char c : word.toCharArray()) {
                // Update the count of the character in the map
                charCount.put(c, charCount.getOrDefault(c, 0) + 1);
            }
        }
        
        // Get the number of words in the array
        int n = words.length;
        
        // Check if each character count is divisible by the number of words
        for (int count : charCount.values()) {
            // If any character count is not divisible by n, return false
            if (count % n != 0) {
                return false;
            }
        }
        
        // If all character counts are divisible by n, return true
        return true;
    }
    
    public static void main(String[] args) {
        Solution solution = new Solution();
        
        // Test case 1
        String[] words1 = {"abc", "aabc", "bc"};
        System.out.println(solution.makeEqual(words1)); // Output: true
        
        // Test case 2
        String[] words2 = {"ab", "a"};
        System.out.println(solution.makeEqual(words2)); // Output: false
    }
}
