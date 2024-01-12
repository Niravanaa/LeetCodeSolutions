class Solution(object):
    def addStrings(self, num1, num2):
        result = []
        carry = 0
        i, j = len(num1) - 1, len(num2) - 1

        while i >= 0 or j >= 0 or carry:
            x = int(num1[i]) if i >= 0 else 0
            y = int(num2[j]) if j >= 0 else 0

            # Add digits and carry
            total = x + y + carry
            carry = total // 10
            digit = total % 10

            # Prepend the current digit to the result
            result.append(str(digit))

            # Move to the next digits in both numbers
            i -= 1
            j -= 1

        # Reverse the result to get the correct order
        return ''.join(result[::-1])