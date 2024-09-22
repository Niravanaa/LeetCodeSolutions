class Solution:
    def findKthNumber(self, n: int, k: int) -> int:
        def count_steps(n, curr, next):
            steps = 0
            while curr <= n:
                steps += min(n + 1, next) - curr
                curr *= 10
                next *= 10
            return steps
        
        curr = 1
        k -= 1  # We treat the first number '1' as already visited
        
        while k > 0:
            steps = count_steps(n, curr, curr + 1)
            if steps <= k:
                # Move to the next sibling
                curr += 1
                k -= steps
            else:
                # Move to the next child
                curr *= 10
                k -= 1
        
        return curr