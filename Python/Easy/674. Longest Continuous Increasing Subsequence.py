class Solution:
    def findLengthOfLCIS(self, nums: List[int]) -> int:
        if not nums:
            return 0
        
        max_len = 1
        current_len = 1
        
        for i in range(1, len(nums)):
            if nums[i] > nums[i - 1]:
                current_len += 1
            else:
                max_len = max(max_len, current_len)
                current_len = 1
        
        # Final check to update max_len in case the longest sequence ends at the last element
        max_len = max(max_len, current_len)
        
        return max_len