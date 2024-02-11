public class Solution {
    public int SubsetXORSum(int[] nums) {
        int result = 0;
        foreach (int num in nums) {
            result |= num;
        }
        return result * (1 << (nums.Length - 1));
    }
}
