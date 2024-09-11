class Solution:
    def numEquivDominoPairs(self, dominoes: List[List[int]]) -> int:
        count = defaultdict(int)

        for domino in dominoes:
            domino_tuple = tuple(sorted(domino))
            count[domino_tuple] += 1

        num_pairs = 0
        for freq in count.values():
            num_pairs += freq * (freq - 1) // 2
    
        return num_pairs
