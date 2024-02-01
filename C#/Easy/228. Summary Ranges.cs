public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        IList<string> result = new List<string>();

        for (int i = 0; i < nums.Length; i++)
        {
            int start = nums[i];

            while (i + 1 < nums.Length && nums[i + 1] == nums[i] + 1)
            {
                i++;
            }

            int end = nums[i];

            result.Add(start == end ? start.ToString() : $"{start}->{end}");
        }

        return result;
    }
}