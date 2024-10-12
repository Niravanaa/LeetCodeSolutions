class Solution:
    def smallestChair(self, times: List[List[int]], targetFriend: int) -> int:
        friends = sorted(enumerate(times), key=lambda x: x[1][0])

        free_chairs = list(range(len(times)))

        leaving_heap = []

        for i, (arrive, leave) in friends:
            while leaving_heap and leaving_heap[0][0] <= arrive:
                leave_time, chair = heappop(leaving_heap)
                heappush(free_chairs, chair)

            chair = heappop(free_chairs)

            if i == targetFriend:
                return chair

            heappush(leaving_heap, (leave, chair))
        
