class Solution:
    def findWords(self, words: List[str]) -> List[str]:
        result = []

        first_row = {'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p'}
        second_row = {'a','s','d','f','g','h','j','k','l'}
        third_row = {'z','x','c','v','b','n','m'}

        for word in words:
            lower_word = set(word.lower())

            if lower_word <= first_row or lower_word <= second_row or lower_word <= third_row:
                result.append(word)
            
        return result