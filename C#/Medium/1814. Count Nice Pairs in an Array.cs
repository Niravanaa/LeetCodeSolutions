public class Solution {
    public int CountNicePairs(int[] nums) {
        Dictionary<int, int> diffs = new Dictionary<int, int>();
        
        int count = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            int currentDiff = nums[i] - ReverseNumber(nums[i]);

            if (diffs.ContainsKey(currentDiff))
            {
                count = (count + diffs[currentDiff]) % 1000000007;
                diffs[currentDiff]++;
            } else { 
                diffs[currentDiff] = 1;
            }
        }

        return count;
    }

    static int ReverseNumber(int number)
    {
        string numberStr = number.ToString();

        char[] charArray = numberStr.ToCharArray();

        Array.Reverse(charArray);

        string reversedStr = new string(charArray);

        int reversedNumber;

        int.TryParse(reversedStr, out reversedNumber);

        return reversedNumber;
    }
}