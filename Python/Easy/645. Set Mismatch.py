class Solution:
    def findErrorNums(self, nums: List[int]) -> List[int]:
        n = len(nums)
        sum_of_nums = sum(nums)
        sum_of_set = sum(set(nums))
        sum_of_first_n = n * (n + 1) // 2
        
        # The duplicated number
        duplicated = sum_of_nums - sum_of_set
        
        # The missing number
        missing = sum_of_first_n - sum_of_set
        
        return [duplicated, missing]