public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int,int> numbers = new Dictionary<int,int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (numbers.ContainsKey(nums[i]))
            {
                numbers[nums[i]]++;
            }

            else
            {
                numbers.Add(nums[i], 1);
            }
        }

        int highestInt = nums[0];

        for (int i = 0; i < nums.Length; i++)
        {
            if (numbers[highestInt] < numbers[nums[i]])
            {
                highestInt = nums[i];
            }
        }

        return highestInt;
    }
}