public class Solution {
    public bool CanJump(int[] nums) {
        int maxReach = 0;

        for (int i = 0; i < nums.Length; i++) {
            if (i > maxReach) {
                return false; // We can't reach the current position
            }
            maxReach = Math.Max(maxReach, i + nums[i]);

            if (maxReach >= nums.Length - 1) {
                return true; // We can reach the end
            }
        }

        return false;
    }
}
