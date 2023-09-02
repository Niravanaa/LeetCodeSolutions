public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int currentInteger = nums[0];

        int numberOfTimes = 1;

        int currentIndex = 1;

        int k = 1;

        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] != currentInteger) {
                currentInteger = nums[i];

                nums[currentIndex] = nums[i];

                currentIndex++;

                numberOfTimes = 1;

                k++;
            } else {
                if (numberOfTimes == 2) {
                    continue;
                } else {
                    numberOfTimes++;

                    nums[currentIndex] = nums[i];

                    currentIndex++;

                    k++;

                    continue;
                }
            }
        }

        return k;
    }
}