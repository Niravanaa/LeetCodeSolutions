class Solution:
    def prefixesDivBy5(self, nums: List[int]) -> List[bool]:
        result = []
        current_value = 0

        for num in nums:
            current_value = (current_value * 2 + num) % 5

            result.append(current_value == 0)

        return result