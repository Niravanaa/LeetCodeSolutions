class Solution:
    def maxKelements(self, nums: List[int], k: int) -> int:
        res = 0

        max_heap = [-n for n in nums]

        heapq.heapify(max_heap)

        while k:
            maxElement = abs(heapq.heappop(max_heap))

            res += maxElement

            newElement = math.ceil(maxElement / 3)

            heapq.heappush(max_heap, -newElement)

            k -= 1
        
        return res