class Solution:
    def convertToBase7(self, num: int) -> str:
        if num == 0:
            return "0"
        
        originalNum = num
        num = abs(num)
        result = ""
        
        while num != 0:
            remainder = num % 7
            num //= 7
            result = str(remainder) + result
        
        if originalNum >= 0:
            return result
        else:
            return "-" + result