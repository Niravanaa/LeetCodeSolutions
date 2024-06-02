class Solution(object):
    def hasPathSum(self, root, targetSum):
        """
        :type root: TreeNode
        :type targetSum: int
        :rtype: bool
        """
        if not root:
            return False
                
            # Check if the current node is a leaf node
        if not root.left and not root.right:
                return targetSum == root.val
            
        # Subtract the current node's value from the targetSum
        targetSum -= root.val
            
        # Recursively check the left and right subtrees
        return self.hasPathSum(root.left, targetSum) or self.hasPathSum(root.right, targetSum)