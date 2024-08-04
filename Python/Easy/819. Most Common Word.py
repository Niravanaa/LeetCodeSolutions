import re
from collections import Counter

class Solution:
    def mostCommonWord(self, paragraph: str, banned: List[str]) -> str:
        # Normalize the paragraph by converting to lower
        # and replacing all punctuation with spaces
        normalized_str = re.sub(r'[^\w\s]', ' ', paragraph.lower())
        
        # Split the paragraph into words
        words = normalized_str.split()
        
        # Create a set of banned words for quick lookup
        banned_words = set(banned)
        
        # Filter out banned words and count the frequency of each word
        word_counts = Counter(word for word in words if word not in banned_words)
        
        # Find the most common word that is not banned
        most_common_word = word_counts.most_common(1)[0][0]
        
        return most_common_word