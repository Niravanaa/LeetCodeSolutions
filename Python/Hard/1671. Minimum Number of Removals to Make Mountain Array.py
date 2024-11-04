class Solution:
    def minimumMountainRemovals(self, nums: List[int]) -> int:
        n = len(nums)
        if n < 3:
            return 0  # Not enough elements to form a mountain
        
        # Step 1: Calculate LIS ending at each index
        lis = [1] * n
        for i in range(n):
            for j in range(i):
                if nums[j] < nums[i]:
                    lis[i] = max(lis[i], lis[j] + 1)

        # Step 2: Calculate LDS starting at each index
        lds = [1] * n
        for i in range(n-1, -1, -1):
            for j in range(n-1, i, -1):
                if nums[j] < nums[i]:
                    lds[i] = max(lds[i], lds[j] + 1)

        # Step 3: Find the maximum length of mountain array
        max_mountain_length = 0
        for i in range(1, n-1):
            if lis[i] > 1 and lds[i] > 1:  # There must be an increasing and decreasing sequence
                max_mountain_length = max(max_mountain_length, lis[i] + lds[i] - 1)

        # Step 4: Calculate the number of elements to remove
        return n - max_mountain_length if max_mountain_length > 0 else n