public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;
        while (left <= right)
        {
            int middle = (left + right) / 2;
            int comparison = nums[middle].CompareTo(target);
            if (comparison == 0)
            {
                return middle;
            }
            else if (comparison < 0)
            {
                left = middle + 1;
            }
            else
            {
                right = middle - 1;
            }
        }

        return left;
    }
}
