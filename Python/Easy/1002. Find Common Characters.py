class Solution:
    def commonChars(self, words: List[str]) -> List[str]:
        reference_counter = Counter(words[0])

        for word in words[1:]:
            word_counter = Counter(word)

            for char in reference_counter:
                reference_counter[char]= min(reference_counter[char], word_counter[char])

        result = []
        for char, count in reference_counter.items():
            result.extend([char] * count)
        
        return result