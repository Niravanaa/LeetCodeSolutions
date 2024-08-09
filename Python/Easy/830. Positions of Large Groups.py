class Solution:
    def largeGroupPositions(self, s: str) -> List[List[int]]:
        intervals = []

        start = 0

        for i in range(1, len(s) + 1):
            if i == len(s) or s[i] != s[start]:
                if i - start >= 3:
                    intervals.append([start, i - 1])
                start = i
        
        return intervals