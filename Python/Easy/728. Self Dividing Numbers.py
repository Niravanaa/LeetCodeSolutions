class Solution:
    def selfDividingNumbers(self, left: int, right: int) -> List[int]:
        result = []

        for num in range(left, right + 1):
            if self.is_self_dividing(num):
                result.append(num)
            
        return result
    
    def is_self_dividing(self, number: int) -> bool:
        original_number = number
        while number > 0:
            digit = number % 10
            if digit == 0 or original_number % digit != 0:
                return False
            number //= 10
        return True