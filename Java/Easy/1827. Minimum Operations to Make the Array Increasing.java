class Solution 
{
    public int minOperations(int[] nums) 
    {
        int operations = 0;

        int prev = nums[0];

        for (int i = 1; i < nums.length; i++)
        {
            if (nums[i] <= prev)
            {
                operations += (prev - nums[i] + 1);
                nums[i] = prev + 1;
            }

            prev = nums[i];
        }

        return operations;
    }
}