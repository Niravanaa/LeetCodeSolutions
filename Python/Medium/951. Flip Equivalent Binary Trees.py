class Solution:
    def flipEquiv(self, root1: Optional[TreeNode], root2: Optional[TreeNode]) -> bool:
        if (not root1 and not root2):
            return True
        
        if (root1 and not root2 or not root1 and root2):
            return False

        if (root1.val is not root2.val):
            return False

        return (self.flipEquiv(root1.left, root2.left) and self.flipEquiv(root1.right, root2.right) or
                self.flipEquiv(root1.left, root2.right) and self.flipEquiv(root1.right, root2.left))