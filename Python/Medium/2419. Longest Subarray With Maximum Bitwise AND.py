class Solution:
    def longestSubarray(self, nums: List[int]) -> int:
        max_and = 0
        for num in nums:
            max_and = max(max_and, num)

        max_length = 0
        current_length = 0

        for num in nums:
            if num == max_and:
                current_length += 1
                max_length = max(max_length, current_length)
            else:
                current_length = 0

        return max_length