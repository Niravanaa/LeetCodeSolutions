class Solution:
    def primeSubOperation(self, nums: List[int]) -> bool:
        primes = []
        max_num = max(nums) + 1
        for current in range(2, max_num):
            for prime in primes:
                if current % prime == 0:
                    break
            else:
                primes.append(current)  
        
        num_length = len(nums)

        for i in range(num_length - 2, -1, -1):
            if nums[i] < nums[i + 1]:
                continue
            
            difference = nums[i] - nums[i + 1]

            j = bisect_right(primes, difference)

            if j == len(primes) or primes[j] >= nums[i]:
                return False
            
            nums[i] -= primes[j]
        
        return True
