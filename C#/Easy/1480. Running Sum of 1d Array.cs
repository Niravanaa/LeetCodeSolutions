public class Solution 
{
    public int[] RunningSum(int[] nums) 
    {
        int[] result = new int[nums.Length];

        result[0] = nums[0];

        for (int i = 1; i < result.Length; i++)
        {
            result[i] = result[i - 1] + nums[i];
        }

        return result;
    }
}