class Solution:
    def dominantIndex(self, nums: List[int]) -> int:
        largest = max(nums)

        second_largest = max([x for x in nums if x != largest])

        if largest >= second_largest * 2:
            return nums.index(largest)
        
        return -1