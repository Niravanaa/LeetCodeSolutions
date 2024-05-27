class Solution(object):
    def fizzBuzz(self, n):
        """
        :type n: int
        :rtype: List[str]
        """
        result = []
        
        for x in range(1, n + 1):
            if (x % 3 == 0 and x % 5 == 0):
                result.append("FizzBuzz")
            elif (x % 3 == 0):
                result.append("Fizz")  # Fixed: should append "Fizz" for multiples of 3
            elif (x % 5 == 0):
                result.append("Buzz")  # Fixed: should append "Buzz" for multiples of 5
            else:
                toAdd = str(x)
                result.append(toAdd)
        
        return result
