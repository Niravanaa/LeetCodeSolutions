class Solution:
    def pivotIndex(self, nums: List[int]) -> int:
        total_sum = sum(nums)
        left_sum = 0
        
        for index, number in enumerate(nums):
            # right_sum is total_sum minus left_sum minus current number
            right_sum = total_sum - left_sum - number
            if left_sum == right_sum:
                return index
            left_sum += number
            
        return -1
