class Solution(object):
    def capitalizeTitle(self, title):
        def capitalize_word(word):
            if len(word) <= 2:
                return word.lower()
            else:
                return word[0].upper() + word[1:].lower()
        
        words = title.split()
        capitalized_words = [capitalize_word(word) for word in words]
        return ' '.join(capitalized_words)
        