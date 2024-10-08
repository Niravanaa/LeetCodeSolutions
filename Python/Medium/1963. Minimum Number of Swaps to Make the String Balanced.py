class Solution:
    def minSwaps(self, s: str) -> int:
        minSwaps = 0
        balance = 0

        for bracket in s:
            if bracket == ']':
                balance += 1
                minSwaps = max(minSwaps, balance)
            else:
                balance -= 1
        
        return -(minSwaps // -2)   
