class Solution:
    def repeatedSubstringPattern(self, s: str) -> bool:
        if len(s) <= 1:
            return False
        double_s = (s + s)[1:-1]
        return s in double_s