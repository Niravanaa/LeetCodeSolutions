class Solution:
    def minAddToMakeValid(self, s: str) -> int:
        balance = 0
        additions_needed = 0

        for paranthesis in s:
            if paranthesis == '(':
                balance += 1
            elif paranthesis == ')':
                if balance > 0:
                    balance -= 1
                else:
                    additions_needed += 1

        return additions_needed + balance
