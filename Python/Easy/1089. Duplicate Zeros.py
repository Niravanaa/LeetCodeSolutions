class Solution:
    def duplicateZeros(self, arr: List[int]) -> None:
        result = []

        for number in arr:
            if number == 0:
                result.append(0)
            result.append(number)
            
            if len(result) == len(arr):
                break

        for i in range(len(arr)):
            arr[i] = result[i]
        
