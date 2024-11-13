class Solution:
    def countFairPairs(self, nums: List[int], lower: int, upper: int) -> int:
        if len(nums) < 2:
            return 0
        
        nums.sort()

        res = 0

        for i in range(len(nums) - 1):
            left = lower - nums[i]
            right = upper - nums[i]
            
            j_start = i + 1 
            j_end = len(nums) - 1 
            
            while j_start <= j_end and nums[j_start] < left:
                j_start += 1
            
            while j_end >= j_start and nums[j_end] > right:
                j_end -= 1

            if j_start <= j_end:
                res += (j_end - j_start + 1)
        
        return res
