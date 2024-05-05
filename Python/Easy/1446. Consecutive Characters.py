class Solution(object):
    def maxPower(self, s):
        """
        :type s: str
        :rtype: int
        """
        result, count = 1, 1
        for i in xrange(1, len(s)):
            if s[i] == s[i-1]:
                count += 1
            else:
                count = 1
            result = max(result, count)
        return result