class Solution:
    def findShortestSubArray(self, nums: List[int]) -> int:
        from collections import defaultdict
    
        # Dictionaries to store the first and last occurrence and frequency of each element
        first_occurrence = {}
        last_occurrence = {}
        frequency = defaultdict(int)
        
        # Calculate the degree and track occurrences
        for index, num in enumerate(nums):
            if num not in first_occurrence:
                first_occurrence[num] = index
            last_occurrence[num] = index
            frequency[num] += 1
        
        # The degree of the array
        degree = max(frequency.values())
        
        # Find the smallest length subarray with the same degree
        min_length = float('inf')
        for num in frequency:
            if frequency[num] == degree:
                min_length = min(min_length, last_occurrence[num] - first_occurrence[num] + 1)
        
        return min_length