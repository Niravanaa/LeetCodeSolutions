class Solution:
    def findTilt(self, root: Optional[TreeNode]) -> int:
        total_tilt = 0
        
        def _sum_and_tilt(node: Optional[TreeNode]) -> int:
            nonlocal total_tilt
            if not node:
                return 0
            
            left_sum = _sum_and_tilt(node.left)
            right_sum = _sum_and_tilt(node.right)
            
            # Calculate node tilt
            node_tilt = abs(left_sum - right_sum)
            total_tilt += node_tilt
            
            # Return the sum of values under this node
            return node.val + left_sum + right_sum
        
        _sum_and_tilt(root)
        return total_tilt