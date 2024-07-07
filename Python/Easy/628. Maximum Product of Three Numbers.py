class Solution:
    def maximumProduct(self, nums: List[int]) -> int:
        nums.sort()
    
        # The maximum product can be either the product of the three largest numbers
        # or the product of the two smallest numbers (which could be negative) and the largest number
        return max(nums[-1] * nums[-2] * nums[-3], nums[0] * nums[1] * nums[-1])
