public class Solution {
    public int MinPairSum(int[] nums) {
        Array.Sort(nums);

        int left = 0, right = nums.Length - 1;

        int minMaxPairSum = int.MinValue;

        while (left < right)
        {
            int currentPairSum = nums[left] + nums[right];

            minMaxPairSum = Math.Max(minMaxPairSum, currentPairSum);

            left++;
 
            right--;
        }

        return minMaxPairSum;
    }
}