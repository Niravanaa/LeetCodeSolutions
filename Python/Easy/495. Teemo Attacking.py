class Solution:
    def findPoisonedDuration(self, timeSeries: List[int], duration: int) -> int:
        if not timeSeries:
            return 0
        
        total_poisoned_time = 0
        end_time = 0

        for time in timeSeries:
            if time < end_time: 
                total_poisoned_time += time + duration - end_time
            else:
                total_poisoned_time += duration
            end_time = time + duration
        
        return total_poisoned_time