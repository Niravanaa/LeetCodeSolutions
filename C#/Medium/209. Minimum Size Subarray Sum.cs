public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int minLength = int.MaxValue;

        int left = 0;

        int sum = 0;

        for (int right = 0; right < nums.Length; right++)
        {
            sum += nums[right];

            while (sum >= target)
            {
                minLength = Math.Min(minLength, right - left + 1);

                sum -= nums[left];

                left++;
            }
        }

        return minLength == int.MaxValue ? 0 : minLength;
    }
}