class Solution:
    def mergeTrees(self, root1: Optional[TreeNode], root2: Optional[TreeNode]) -> Optional[TreeNode]:
        if not root1 and not root2:
            return None
        if not root1:
            return root2
        if not root2:
            return root1
        
        # Create a new TreeNode with the sum of values from root1 and root2
        merged_root = TreeNode(root1.val + root2.val)
        
        # Recursively merge the left and right children
        merged_root.left = self.mergeTrees(root1.left, root2.left)
        merged_root.right = self.mergeTrees(root1.right, root2.right)
        
        return merged_root