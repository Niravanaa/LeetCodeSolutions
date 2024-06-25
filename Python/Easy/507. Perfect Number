class Solution:
    def checkPerfectNumber(self, num: int) -> bool:
        # A perfect number must be at least 2, as 1 cannot be perfect.
        if num == 1:
            return False

        # Initialize the sum of divisors with the first proper divisor, which is always 1.
        sum_of_divisors = 1
        # Start checking for other divisors from 2 onwards.
        divisor = 2

        # Only iterate up to the square root of num to avoid redundant calculations.
        # Any divisor greater than the square root would have already been accounted for.
        while divisor * divisor <= num:
            # If divisor is a proper divisor of num,
            # then num is divisible by divisor without a remainder.
            if num % divisor == 0:
                # Add the divisor to the sum.
                sum_of_divisors += divisor
                # If divisor is not the square root of num,
                # add the corresponding co-divisor (num / divisor).
                if divisor != num // divisor:
                    sum_of_divisors += num // divisor
            # Proceed to check the next potential divisor.
            divisor += 1

        # A number is perfect if the sum of its proper divisors,
        # including 1 but not the number itself, equals the number.
        return sum_of_divisors == num
