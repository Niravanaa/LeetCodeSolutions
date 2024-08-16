class Solution:
    def smallestRangeI(self, nums: List[int], k: int) -> int:
        nums.sort()
        
        min_value = nums[0] + k
        max_value = nums[-1] - k
        
        min_score = max(0, max_value - min_value)
        
        return min_score