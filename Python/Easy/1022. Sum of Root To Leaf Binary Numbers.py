class Solution:
    def sumRootToLeaf(self, root: Optional[TreeNode]) -> int:
        def dfs(node, current_value):
            if not node:
                return 0
            
            # Calculate the current binary value by shifting the previous value left and adding the current node's value
            current_value = (current_value << 1) | node.val
            
            # If it's a leaf node, return the current value
            if not node.left and not node.right:
                return current_value
            
            # Continue the DFS for left and right children
            left_sum = dfs(node.left, current_value)
            right_sum = dfs(node.right, current_value)
            
            # Sum the values from the left and right subtrees
            return left_sum + right_sum
        
        # Start the DFS from the root with an initial value of 0
        return dfs(root, 0)