class Solution:
    def maximumSwap(self, num: int) -> int:
        digits = list(str(num))

        last = {int(d) : i for i, d in enumerate(digits)}

        for i, d in enumerate(digits):
            for larger in range(9, int(d), -1):
                if last.get(larger, -1) > i:
                    digits[i], digits[last[larger]] = digits[last[larger]], digits[i]

                    return int(''.join(digits))

        return numd