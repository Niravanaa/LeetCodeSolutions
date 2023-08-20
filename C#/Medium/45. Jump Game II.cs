public class Solution {
    public int Jump(int[] nums) {
        if (nums.Length <= 1) {
            return 0;  // No jumps needed if array length is 0 or 1
        }
        
        int maxReach = nums[0];  // Maximum index reachable from the current position
        int steps = nums[0];     // Remaining steps at the current jump
        int jumps = 1;           // Initial jump taken
        
        for (int i = 1; i < nums.Length - 1; i++) {
            maxReach = Math.Max(maxReach, i + nums[i]);  // Update the maximum reachable index
            
            steps--;  // Use up a step
            
            if (steps == 0) {
                jumps++;             // Take a jump when steps are used up
                steps = maxReach - i; // Replenish steps using maxReach - current position
            }
        }
        
        return jumps;
    }
}
