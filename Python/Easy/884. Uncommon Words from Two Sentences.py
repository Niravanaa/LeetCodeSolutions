class Solution:
    def uncommonFromSentences(self, s1: str, s2: str) -> List[str]:
        combined = s1 + " " + s2

        word_count = Counter(combined.split())

        return [word for word, count in word_count.items() if count == 1]