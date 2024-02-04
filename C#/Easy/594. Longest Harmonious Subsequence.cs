public class Solution {
    public int FindLHS(int[] nums) {
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
        
        // Count the frequency of each number in the array
        foreach (int num in nums) {
            if (frequencyMap.ContainsKey(num)) {
                frequencyMap[num]++;
            } else {
                frequencyMap[num] = 1;
            }
        }
        
        int maxLength = 0;
        
        // Iterate through the keys in the frequency map
        foreach (int key in frequencyMap.Keys) {
            // Check if the key+1 exists in the map
            if (frequencyMap.ContainsKey(key + 1)) {
                // Update the maximum length if a harmonious subsequence is found
                maxLength = Math.Max(maxLength, frequencyMap[key] + frequencyMap[key + 1]);
            }
        }
        
        return maxLength;
    }
}
