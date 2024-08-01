class Solution:
    def minDiffInBST(self, root: Optional[TreeNode]) -> int:
        def inOrderTraversal(node: TreeNode, values: list):
            if not node:
                return
            
            inOrderTraversal(node.left, values)
            values.append(node.val)
            inOrderTraversal(node.right, values)

        values = []

        inOrderTraversal(root, values)

        min_diff = float('inf')
        for i in range(1, len(values)):
            min_diff = min(min_diff, values[i] - values[i - 1])
        
        return min_diff