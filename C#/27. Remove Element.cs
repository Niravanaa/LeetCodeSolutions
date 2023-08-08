public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int pointer = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                int temp = nums[pointer];

                nums[pointer] = nums[i];

                nums[i] = temp;

                pointer++;
            }
        }

        return pointer;
    }
}