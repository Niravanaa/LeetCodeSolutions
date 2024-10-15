class Solution:
    def minimumSteps(self, s: str) -> int:
        num_swaps = 0
        zeroes_before = s.count('0')

        for char in s:
            if char == '1':
                num_swaps += zeroes_before
            else:
                zeroes_before -= 1
        
        return num_swaps