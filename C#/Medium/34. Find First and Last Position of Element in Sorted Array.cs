public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        // Check if the input array is null or empty
        if (nums == null || nums.Length == 0) {
            return new int[] { -1, -1 }; // Return [-1, -1] to indicate not found
        }

        // Initialize variables to store the starting and ending positions
        int start = -1;
        int end = -1;

        // Binary search for the left boundary (starting position)
        int left = 0;
        int right = nums.Length - 1;

        while (left <= right) {
            int mid = left + (right - left) / 2;

            // If the middle element is equal to the target, update the starting position
            if (nums[mid] == target) {
                start = mid;
                right = mid - 1; // Move left to find the leftmost occurrence
            } else if (nums[mid] < target) {
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }

        // Binary search for the right boundary (ending position)
        left = 0;
        right = nums.Length - 1;

        while (left <= right) {
            int mid = left + (right - left) / 2;

            // If the middle element is equal to the target, update the ending position
            if (nums[mid] == target) {
                end = mid;
                left = mid + 1; // Move right to find the rightmost occurrence
            } else if (nums[mid] < target) {
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }

        // Return the starting and ending positions
        return new int[] { start, end };
    }
}
