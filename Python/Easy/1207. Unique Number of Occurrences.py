class Solution:
    def uniqueOccurrences(self, arr: List[int]) -> bool:
        # Count occurrences of each number in the list
        count = Counter(arr)

        # Create a set of the occurrence counts
        occurrences = set(count.values())

        # If the length of the occurrences set is the same as the count of elements,
        # then all occurrences are unique
        return len(occurrences) == len(count.values())