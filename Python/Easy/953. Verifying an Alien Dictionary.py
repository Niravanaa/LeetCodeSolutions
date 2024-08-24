class Solution:
    def isAlienSorted(self, words: List[str], order: str) -> bool:
        order_index = {char: idx for idx, char in enumerate(order)}

        def compare_words(word1, word2):
            for char1, char2 in zip(word1, word2):
                if order_index[char1] < order_index[char2]:
                    return True
                elif order_index[char1] > order_index[char2]:
                    return False
            return len(word1) <= len(word2)

        for i in range(len(words) - 1):
            if not compare_words(words[i], words[i + 1]):
                return False
        
        return True
