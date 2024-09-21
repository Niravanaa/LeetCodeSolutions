class Solution:
    def lexicalOrder(self, n: int) -> List[int]:
        result = []
        current = 1
        
        for _ in range(n):
            result.append(current)
            
            # Try to move down (multiply by 10)
            if current * 10 <= n:
                current *= 10
            else:
                # Otherwise, try to move to the next number
                # If current is max or exceeds n, backtrack
                if current >= n:
                    current //= 10
                
                current += 1
                # Skip trailing zeros (we cannot have numbers like 10, 20, 30 directly)
                while current % 10 == 0:
                    current //= 10

        return result