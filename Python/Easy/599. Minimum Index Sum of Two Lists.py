class Solution:
    def findRestaurant(self, list1: List[str], list2: List[str]) -> List[str]:
        index_sum_map = {}
    
        # Populate index_sum_map with strings from list1 and their indices
        for index, s1 in enumerate(list1):
            index_sum_map[s1] = index
        
        result = []
        min_index_sum = float('inf')
        
        # Iterate through list2 to find common strings with the least index sum
        for index, s2 in enumerate(list2):
            if s2 in index_sum_map:
                index_sum = index_sum_map[s2] + index
                if index_sum < min_index_sum:
                    min_index_sum = index_sum
        
        # Collect all strings with the minimum index sum
        for index, s2 in enumerate(list2):
            if s2 in index_sum_map:
                index_sum = index_sum_map[s2] + index
                if index_sum == min_index_sum:
                    result.append(s2)
        
        return result