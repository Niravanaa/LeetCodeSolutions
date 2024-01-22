import java.util.Arrays;
import java.util.ArrayList;
import java.util.List;

class Solution {
    public int[] numberGame(int[] nums) {
        Arrays.sort(nums);

        List<Integer> result = new ArrayList<>();

        int firstPointer = 1;
        int secondPointer = 0;

        while (firstPointer < nums.length || secondPointer < nums.length) {
            if (firstPointer < nums.length) {
                result.add(nums[firstPointer]);
                firstPointer += 2;
            }

            if (secondPointer < nums.length) {
                result.add(nums[secondPointer]);
                secondPointer += 2;
            }
        }

        return result.stream().mapToInt(Integer::intValue).toArray();
    }
}
