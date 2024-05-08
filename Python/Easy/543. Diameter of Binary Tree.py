class Solution(object):
    def diameterOfBinaryTree(self, root):
        def height(node, max_diameter):
            if not node:
                return 0
            
            left_height = height(node.left, max_diameter)
            right_height = height(node.right, max_diameter)
            
            # Update the maximum diameter encountered so far
            max_diameter[0] = max(max_diameter[0], left_height + right_height)
            
            return 1 + max(left_height, right_height)
        
        if not root:
            return 0
        
        max_diameter = [0]  # Mutable list to store the maximum diameter
        height(root, max_diameter)
        return max_diameter[0]