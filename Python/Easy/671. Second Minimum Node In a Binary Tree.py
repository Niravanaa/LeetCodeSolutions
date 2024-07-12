class Solution:
    def findSecondMinimumValue(self, root: Optional[TreeNode]) -> int:
        def dfs(node):
            if not node:
                return
            unique_values.add(node.val)
            dfs(node.left)
            dfs(node.right)
        
        unique_values = set()
        dfs(root)
        
        # If there are fewer than two unique values, return -1
        if len(unique_values) < 2:
            return -1
        
        # Otherwise, find and return the second minimum value
        unique_values.remove(min(unique_values))  # Remove the minimum value
        return min(unique_values)