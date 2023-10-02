public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        HashSet<int> seen = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++) {
            if (seen.Contains(nums[i])) {
                return true;
            }

            seen.Add(nums[i]);

            // Remove elements from the set when the window size exceeds k
            if (seen.Count > k) {
                seen.Remove(nums[i - k]);
            }
        }

        return false;
    }
}
