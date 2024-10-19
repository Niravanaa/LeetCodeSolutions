class Solution:
    def countMaxOrSubsets(self, nums: List[int]) -> int:
        max_or = 0
        for num in nums:
            max_or |= num
        
        count = 0
        n = len(nums)
        
        for r in range(1, n + 1):
            for subset in combinations(nums, r):
                current_or = 0
                for num in subset:
                    current_or |= num
                if current_or == max_or:
                    count += 1
        
        return count