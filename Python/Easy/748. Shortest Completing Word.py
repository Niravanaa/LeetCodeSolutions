class Solution:
    def shortestCompletingWord(self, licensePlate: str, words: List[str]) -> str:
        from collections import Counter

        def normalize(s):
            return Counter(char.lower() for char in s if char.isalpha())

        license_counter = normalize(licensePlate)

        def is_completing(word):
            word_counter = Counter(word.lower())
            for char, count in license_counter.items():
                if word_counter[char] < count:
                    return False
            return True
        
        shortest_word = None
        for word in words:
            if is_completing(word):
                if shortest_word is None or len(word) < len(shortest_word):
                    shortest_word = word

        return shortest_word