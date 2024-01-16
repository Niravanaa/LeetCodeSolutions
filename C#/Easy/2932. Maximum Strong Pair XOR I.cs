public class Solution 
{
    public int MaximumStrongPairXor(int[] nums) 
    {
        int maxXOR = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i; j < nums.Length; j++)
            {
                if (Math.Abs(nums[i] - nums[j]) <= Math.Min(nums[i], nums[j])) maxXOR = Math.Max(maxXOR, nums[i] ^ nums[j]);
            }
        }

        return maxXOR;
    }
}