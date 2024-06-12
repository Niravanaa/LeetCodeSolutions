class Solution:
    def sumOfLeftLeaves(self, root: Optional[TreeNode]) -> int:
        if root is None:
            return 0
        
        result = 0
        if root.left is not None:
            if root.left.left is None and root.left.right is None:  # Check if it's a left leaf
                result += root.left.val
            else:
                result += self.sumOfLeftLeaves(root.left)
        
        if root.right is not None:
            result += self.sumOfLeftLeaves(root.right)
        
        return result