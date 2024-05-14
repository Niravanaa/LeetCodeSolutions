class Solution {
    public String triangleType(int[] nums) {
        // Check if the array contains exactly 3 elements
        if (nums.length != 3) {
            return "none"; // If not, it cannot form a triangle
        }

        // Sort the sides of the triangle in non-decreasing order
        Arrays.sort(nums);

        // Check if the triangle cannot be formed
        if (nums[0] + nums[1] <= nums[2]) {
            return "none"; // If the sum of two shorter sides is less than or equal to the longest side,
                           // it's not a triangle
        }

        // Check for equilateral triangle
        if (nums[0] == nums[1] && nums[1] == nums[2]) {
            return "equilateral"; // If all sides are equal, it's an equilateral triangle
        }

        // Check for isosceles triangle
        if (nums[0] == nums[1] || nums[1] == nums[2]) {
            return "isosceles"; // If two sides are equal, it's an isosceles triangle
        }

        // Otherwise, it's scalene
        return "scalene"; // If none of the above conditions match, it's a scalene triangle where all
                          // sides are different
    }
}
