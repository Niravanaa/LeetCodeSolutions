public class Solution {
    public IList < IList < int >> ThreeSum(int[] nums) {
        IList < IList < int >> result = new List < IList < int >> ();

        if (nums == null || nums.Length < 3) {
            return result;
        }

        Array.Sort(nums); // Sort the input array.

        for (int i = 0; i < nums.Length - 2; i++) {
            if (i > 0 && nums[i] == nums[i - 1]) {
                continue; // Skip duplicate elements to avoid duplicate triplets.
            }

            int left = i + 1;
            int right = nums.Length - 1;
            int target = -nums[i]; // Calculate the target sum.

            while (left < right) {
                int sum = nums[left] + nums[right];

                if (sum == target) {
                    result.Add(new List < int > {
                        nums[i],
                        nums[left],
                        nums[right]
                    });

                    // Skip duplicate elements.
                    while (left < right && nums[left] == nums[left + 1]) {
                        left++;
                    }
                    while (left < right && nums[right] == nums[right - 1]) {
                        right--;
                    }

                    left++;
                    right--;
                } else if (sum < target) {
                    left++;
                } else {
                    right--;
                }
            }
        }

        return result;
    }

}