class Solution {
    public int largestSumAfterKNegations(int[] nums, int k) {
        // Sort the array to bring smallest elements to the front
        Arrays.sort(nums);

        // Negate the smallest elements k times
        for (int i = 0; i < nums.length && k > 0; i++) {
            if (nums[i] < 0) {
                nums[i] = -nums[i];
                k--;
            }
        }

        // If there are remaining operations, use them on the smallest element
        // Sort again to find the smallest element
        Arrays.sort(nums);

        if (k % 2 == 1) {
            // If k is odd, negate the smallest element
            nums[0] = -nums[0];
        }

        // Sum up the array
        int sum = 0;
        for (int num : nums) {
            sum += num;
        }

        return sum;
    }
}