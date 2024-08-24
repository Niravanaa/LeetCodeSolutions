class Solution:
    def repeatedNTimes(self, nums: List[int]) -> int:
        count = {}
        
        for number in nums:
            if number in count:
                return number
            count[number] = 1
        
        return -1