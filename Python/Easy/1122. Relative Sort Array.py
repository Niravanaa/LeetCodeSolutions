class Solution:
    def relativeSortArray(self, arr1: List[int], arr2: List[int]) -> List[int]:
        result = []

        count = Counter(arr1)

        for number in arr2:
            result.extend([number] * count[number])
            del count[number]
        
        remaining = sorted(count.elements())

        return result + remaining
