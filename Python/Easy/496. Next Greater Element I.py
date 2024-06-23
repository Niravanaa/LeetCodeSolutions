class Solution:
    def nextGreaterElement(self, nums1: List[int], nums2: List[int]) -> List[int]:
        # Dictionary to store the next greater element for each number in nums2
        next_greater = {}
        # Stack to keep track of the elements for which we need to find the next greater element
        stack = []
        
        # Iterate over nums2
        for num in nums2:
            # While there is an element in the stack and the current number is greater than the element on the stack top
            while stack and num > stack[-1]:
                next_greater[stack.pop()] = num
            # Push the current number onto the stack
            stack.append(num)
        
        # For elements that do not have a next greater element, we assign -1
        while stack:
            next_greater[stack.pop()] = -1
        
        # Construct the result array for nums1 based on the next_greater dictionary
        result = [next_greater[num] for num in nums1]
        return result