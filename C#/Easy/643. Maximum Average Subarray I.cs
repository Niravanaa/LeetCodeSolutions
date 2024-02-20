
public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        if (nums.Length == 0 || k > nums.Length) return 0;

        double result = double.MinValue;
        double sum = 0;

        for (int i = 0; i < k; i++)
        {
            sum += nums[i];
        }

        result = sum / k;

        for (int i = k; i < nums.Length; i++)
        {
            sum -= nums[i - k];

            sum += nums[i];

            result = Math.Max(result, sum / k);
        }

        return result;
    }
}