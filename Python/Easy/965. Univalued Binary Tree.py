class Solution:
    def isUnivalTree(self, root: Optional[TreeNode]) -> bool:
        if not root:
            return True

        def dfs(node):
            if not node:
                return []
            
            return [node.val] + dfs(node.left) + dfs(node.right)
        
        values = dfs(root)
        unique_values = set(values)

        return len(unique_values) == 1