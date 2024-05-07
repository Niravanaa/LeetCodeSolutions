class Solution {
    public void moveZeroes(int[] nums) {
        int nonZeroPointer = 0;

        for (int i = 0; i < nums.length; i++) {
            if (nums[i] != 0) {
                nums[nonZeroPointer] = nums[i];

                if (nonZeroPointer != i) {
                    nums[i] = 0;
                }

                nonZeroPointer++;
            }
        }
    }
}