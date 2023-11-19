public class Solution {
    public int ReductionOperations(int[] nums) {
        Dictionary<int, int> freqDict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!freqDict.ContainsKey(nums[i]))
            {
                freqDict.Add(nums[i], 1);
            }

            else
            {
                freqDict[nums[i]]++;
            }
        }

        int[] numberKeys = freqDict.Keys.ToArray();

        int result = 0;

        for (int i = 1; i < numberKeys.Length; i++)
        {
            result += (freqDict[numberKeys[i]] * i);
        }

        return result;
    }
}