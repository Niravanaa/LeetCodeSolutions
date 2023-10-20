public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        if (nums.Length == 1)
        {
            return nums;
        }

        Dictionary<int, int> frequencies = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (frequencies.ContainsKey(nums[i]))
            {
                frequencies[nums[i]]++;

                continue;
            }

            frequencies.Add(nums[i], 1);
        }

        List<int> frequentElements = new List<int>();

        for (int i = 0; i < k; i++)
        {
            var currentMax = frequencies.Aggregate((x, y) => x.Value > y.Value ? x : y);

            frequentElements.Add(currentMax.Key);

            frequencies.Remove(currentMax.Key);
        }

        return frequentElements.ToArray();
    }
}