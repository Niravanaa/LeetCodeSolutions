class Solution:
    def is_identical(self, tree1: Optional[TreeNode], tree2: Optional[TreeNode]) -> bool:
        if not tree1 and not tree2:
            return True
        if not tree1 or not tree2:
            return False
        return (tree1.val == tree2.val and 
                self.is_identical(tree1.left, tree2.left) and 
                self.is_identical(tree1.right, tree2.right))

    def isSubtree(self, root: Optional[TreeNode], subRoot: Optional[TreeNode]) -> bool:
        if not root:
            return False
        if self.is_identical(root, subRoot):
            return True
        return self.isSubtree(root.left, subRoot) or self.isSubtree(root.right, subRoot)
