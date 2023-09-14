public class Solution {
    public IList<int> FindSubstring(string s, string[] words) {
        // Initialize a list to store the results.
        List<int> result = new List<int>();
        
        // Get the length of a single word and the total length of all words.
        int wordLength = words[0].Length;
        int totalLength = wordLength * words.Length;
        
        // Create a dictionary to store the frequency of each word.
        Dictionary<string, int> wordCount = new Dictionary<string, int>();
        foreach (string word in words) {
            if (wordCount.ContainsKey(word)) {
                wordCount[word]++;
            } else {
                wordCount[word] = 1;
            }
        }
        
        // Iterate through the string s.
        for (int i = 0; i <= s.Length - totalLength; i++) {
            // Extract a substring of length totalLength.
            string substring = s.Substring(i, totalLength);
            
            // Create a dictionary to store the frequency of words in the current substring.
            Dictionary<string, int> currentWordCount = new Dictionary<string, int>();
            
            // Split the substring into words of length wordLength.
            for (int j = 0; j < totalLength; j += wordLength) {
                string word = substring.Substring(j, wordLength);
                if (currentWordCount.ContainsKey(word)) {
                    currentWordCount[word]++;
                } else {
                    currentWordCount[word] = 1;
                }
            }
            
            // Compare the currentWordCount with the wordCount dictionary.
            if (IsEqual(wordCount, currentWordCount)) {
                result.Add(i); // If they are equal, add the index to the result.
            }
        }
        
        return result;
    }
    
    // Helper function to check if two dictionaries are equal.
    private bool IsEqual(Dictionary<string, int> dict1, Dictionary<string, int> dict2) {
        if (dict1.Count != dict2.Count) {
            return false;
        }
        
        foreach (var kvp in dict1) {
            if (!dict2.ContainsKey(kvp.Key) || dict2[kvp.Key] != kvp.Value) {
                return false;
            }
        }
        
        return true;
    }
}
