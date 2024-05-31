from collections import Counter

class Solution:
    def intersect(self, nums1, nums2):
        # Count the frequency of elements in both arrays
        count1 = Counter(nums1)
        count2 = Counter(nums2)
        
        # Initialize the result list
        result = []
        
        # Iterate through the first count dictionary
        for num in count1:
            if num in count2:
                # Find the minimum count between the two arrays
                min_count = min(count1[num], count2[num])
                # Add the element min_count times to the result list
                result.extend([num] * min_count)
        
        return result