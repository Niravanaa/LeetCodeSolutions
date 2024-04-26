class Solution(object):
    def numOfStrings(self, patterns, word):
        return sum(pattern in word for pattern in patterns)