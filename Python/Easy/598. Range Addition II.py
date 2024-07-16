class Solution:
    def maxCount(self, m: int, n: int, ops: List[List[int]]) -> int:
        if not ops:
            return m * n
        
        # Initialize with the maximum possible dimensions
        max_a = float('inf')
        max_b = float('inf')
        
        # Find the minimum ai and bi from ops
        for op in ops:
            max_a = min(max_a, op[0])
            max_b = min(max_b, op[1])
        
        # The number of maximum integers is the product of max_a and max_b
        return max_a * max_b