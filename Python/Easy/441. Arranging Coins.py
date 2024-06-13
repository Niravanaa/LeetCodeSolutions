class Solution:
    def arrangeCoins(self, n: int) -> int:
        filled = 0
        
        while n >= filled + 1:
            filled += 1
            n -= filled
            
        return filled
