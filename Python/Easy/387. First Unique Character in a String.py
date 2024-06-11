class Solution:
    def firstUniqChar(self, s: str) -> int:
        counted = []
        for character in s:
            if character in counted:
                continue
            else:
                counted.append(character)
            if s.count(character) == 1:
                return s.index(character)
        return -1