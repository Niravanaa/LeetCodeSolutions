public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> d = new Dictionary<int, int>();

        int[] result = new int[2];

        for (int i = 0; i < nums.Length; i++)
        {
            d.Add(i, nums[i]);
        }

        int first = 0;
        int second = 1;

        for (int i = first; i < nums.Length; i++)
        {
            d.Remove(i);

            if (d.ContainsValue(target - nums[i]))
            {
                first = i;
                break;
            }

            d.Add(i, nums[i]);
        }

        for (int i = first + 1; i < nums.Length; i++)
        {
            if (nums[i] == target - nums[first])
            {
                second = i;
                break;
            }
        }

        result[0] = first;
        result[1] = second;

        return result;
    }
}