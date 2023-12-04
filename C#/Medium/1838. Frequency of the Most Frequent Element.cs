public class Solution {
    public int MaxFrequency(int[] nums, int k) {
        Array.Sort(nums);

        int maxFreq = 0;
        int left = 0;
        long sum = 0;

        for (int right = 0; right < nums.Length; right++) {
            sum += nums[right];

            while ((long)nums[right] * (right - left + 1) - sum > k) {
                sum -= nums[left];
                left++;
            }

            maxFreq = Math.Max(maxFreq, right - left + 1);
        }

        return maxFreq;
    }
}
