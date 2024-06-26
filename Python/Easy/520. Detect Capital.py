class Solution:
    def detectCapitalUse(self, word: str) -> bool:
        if (word == word.upper()):
            return True
        if (word == word.lower()):
            return True
        if (word == word[0].upper() + word[1:].lower()):
            return True
        return False