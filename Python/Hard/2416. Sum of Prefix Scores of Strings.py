class Solution:
    def sumPrefixScores(self, words: List[str]) -> List[int]:
        from collections import defaultdict

        prefix_count = defaultdict(int)

        for word in words:
            prefix = ""
            for char in word:
                prefix += char
                prefix_count[prefix] += 1

        answer = []
        for word in words:
            total_score = 0
            prefix = ""
            for char in word:
                prefix += char
                total_score += prefix_count[prefix]
            answer.append(total_score)
        
        return answer