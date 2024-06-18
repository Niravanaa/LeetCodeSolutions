class Solution:
    def findMaxConsecutiveOnes(self, nums: List[int]) -> int:
        count = 0
        currMax = 0

        for number in nums:
            if number == 1:
                count += 1
            else:
                currMax = max(count, currMax)
                count = 0

        return max(count, currMax)