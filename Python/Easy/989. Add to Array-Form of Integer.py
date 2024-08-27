class Solution:
    def addToArrayForm(self, num: List[int], k: int) -> List[int]:
        firstInt = 0
        for digit in num:
            firstInt = firstInt * 10 + digit
        
        # Add k to the integer
        finalNumber = firstInt + k
        
        # Edge case: if finalNumber is 0, return [0]
        if finalNumber == 0:
            return [0]
        
        # Convert the final number back to an array of digits
        result = []
        while finalNumber > 0:
            result.append(finalNumber % 10)
            finalNumber //= 10
        
        # Since digits are added in reverse order, reverse the list
        result.reverse()
        
        return result