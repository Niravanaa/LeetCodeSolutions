class Solution:
    def thirdMax(self, nums: List[int]) -> int:
        # Use a set to handle duplicates
        unique_nums = list(set(nums))
        
        # Sort the unique numbers in descending order
        unique_nums.sort(reverse=True)
        
        # If there are at least three distinct numbers, return the third maximum
        if len(unique_nums) >= 3:
            return unique_nums[2]
        else:
            # Otherwise, return the maximum number
            return unique_nums[0]