public class Solution 
{
    public int LongestAlternatingSubarray(int[] nums, int threshold) 
    {
        int n = nums.Length;

        int longest = 0;

        int len = 0;

        for (int i = 0; i < n; i++)
        {
            if (i > 0 && Math.Max(nums[i], nums[i - 1]) <= threshold && OddEven(nums[i], nums[i - 1]))
            {
                len++;
            }

            else
            {
                if (nums[i] % 2 == 0 && nums[i] <= threshold)
                {
                    len = 1;
                }

                else
                {
                    len = 0;
                }
            }

            longest = Math.Max(longest, len);
        }

        return longest;
    }

    public bool OddEven(int a, int b)
    {
        return (a & 1) != (b & 1);
    }
}