public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        int[] distinctNums = nums.Distinct().ToArray();

        if (nums.Length > distinctNums.Length)
        {
            return true;
        }

        return false;
    }
}
