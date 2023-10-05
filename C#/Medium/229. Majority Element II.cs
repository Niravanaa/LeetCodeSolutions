public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        Dictionary<int, int> numbers = new Dictionary<int, int>();

        IList<int> result = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {            
            if (numbers.ContainsKey(nums[i]))
            {
                numbers[nums[i]]++;
                
                if (numbers[nums[i]] > nums.Length / 3 && !result.Contains(nums[i]))
                {
                    result.Add(nums[i]);
                }
            }

            else
            {
                numbers.Add(nums[i], 1);

                if (numbers[nums[i]] > nums.Length / 3 && !result.Contains(nums[i]))
                {
                    result.Add(nums[i]);
                }
            }
        }

        return result;
    }
}