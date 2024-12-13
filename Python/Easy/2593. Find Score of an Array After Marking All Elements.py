class Solution:
    def findScore(self, nums: List[int]) -> int:
        heap = [(value, idx) for idx, value in enumerate(nums)]

        heapq.heapify(heap)

        visited = set()
        score = 0

        while heap:
            value, idx = heapq.heappop(heap)

            if idx in visited:
                continue

            score += value

            visited.add(idx)
            if idx - 1 >= 0:
                visited.add(idx - 1)
            if idx + 1 < len(nums):
                visited.add(idx + 1)
            
        return score