public class Solution {
    public string FindDifferentBinaryString(string[] nums) {
        HashSet<string> set = new HashSet<string>(nums);

        int n = nums[0].Length;

        for (int i = 0; i < (1 << n); i++)
        {
            string binaryString = Convert.ToString(i, 2).PadLeft(n, '0');
            
            if (!set.Contains(binaryString))
            {
                return binaryString;
            }
        }

        return string.Empty;
    }
}