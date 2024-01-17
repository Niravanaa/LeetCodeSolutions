class Solution(object):
    def removeOuterParentheses(self, s):
        result = []
        stack = []

        start = 0
        for i in range(len(s)):
            if s[i] == '(':
                stack.append('(')
            else:
                stack.pop()

            if not stack:
                result.append(s[start + 1:i])
                start = i + 1

        return ''.join(result)