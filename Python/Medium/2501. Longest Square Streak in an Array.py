class Solution:
    def longestSquareStreak(self, nums: List[int]) -> int:
        s = set(nums)
        ans = -1

        for v in s:
            t = 0
            while v in s:
                v *= v
                t += 1
            if (t > 1):
                ans = max(t, ans)
        
        return ans
