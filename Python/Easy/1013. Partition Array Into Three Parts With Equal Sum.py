class Solution:
    def canThreePartsEqualSum(self, arr: List[int]) -> bool:
        """
        This function determines whether an array can be partitioned into three non-empty parts
        with equal sums. It returns True if possible, otherwise False.
        
        :param arr: List[int] - The input list of integers
        :return: bool - True if the array can be partitioned into three parts with equal sum, False otherwise
        """
        # Step 1: Calculate the total sum of the array elements
        total = sum(arr)
        
        # Step 2: Check if the total sum is divisible by 3
        # If not, it's impossible to partition the array into three parts with equal sum
        if total % 3 != 0:
            return False
        
        # Step 3: Determine the target sum for each partition
        target_sum = total // 3
        
        # Initialize variables:
        # 'parts' to count the number of valid partitions found
        # 'curr' to keep track of the current running sum for each potential partition
        parts, curr = 0, 0
        
        # Step 4: Iterate through the array to try and form partitions
        for x in arr:
            # Add the current element to the running sum
            curr += x
            
            # If the running sum equals the target sum, a valid partition is found
            if curr == target_sum:
                # Increment the partition count
                parts += 1
                
                # Reset the running sum to start calculating the next partition
                curr = 0
                
                # Note: The loop continues even after finding 2 partitions to ensure the third part can be formed

        # Step 5: Return True if we've found at least 3 valid partitions, False otherwise
        return parts >= 3
