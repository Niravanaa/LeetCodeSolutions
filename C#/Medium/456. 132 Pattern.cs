public class Solution {
    public bool Find132pattern(int[] nums) {
        if (nums == null || nums.Length < 3) {
            return false; // We need at least 3 elements to form the pattern.
        }

        int n = nums.Length;
        int[] minSoFar = new int[n];
        minSoFar[0] = nums[0];

        // Find the minimum element up to index i.
        for (int i = 1; i < n; i++) {
            minSoFar[i] = Math.Min(minSoFar[i - 1], nums[i]);
        }

        Stack<int> stack = new Stack<int>();

        // Iterate through the array from right to left.
        for (int j = n - 1; j >= 0; j--) {
            // Check if nums[j] is greater than the minimum element before it.
            if (nums[j] > minSoFar[j]) {
                // Pop elements from the stack while they are smaller than minSoFar[j].
                while (stack.Count > 0 && stack.Peek() <= minSoFar[j]) {
                    stack.Pop();
                }
                // If there's an element in the stack that is smaller than nums[j], return true.
                if (stack.Count > 0 && stack.Peek() < nums[j]) {
                    return true;
                }
                // Push nums[j] onto the stack.
                stack.Push(nums[j]);
            }
        }

        return false; // No 132 pattern found.
    }
}
