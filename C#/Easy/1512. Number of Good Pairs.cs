public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        Dictionary<int, int> numbers = new Dictionary<int, int>();

        int pairs = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (numbers.ContainsKey(nums[i]))
            {
                pairs += numbers[nums[i]];
                
                numbers[nums[i]]++;

                continue;
            }

            numbers.Add(nums[i], 1);
        }

        return pairs;
    }
}