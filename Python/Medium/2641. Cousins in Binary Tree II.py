# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def replaceValueInTree(self, root: Optional[TreeNode]) -> Optional[TreeNode]:
        # This function will replace the values of the nodes in the tree.

        # Helper function to perform DFS (Depth-First Search) and sum up the values at each depth.
        def dfs_sum_values(node, depth):
            # If the node is None (doesn't exist), just return (stop here).
            if node is None:
                return
            
            # If we are at a new depth, we need to create a place for its sum in our list.
            if len(depth_sums) <= depth:
                depth_sums.append(0)  # Add a new entry for this depth's sum.
            
            # Add the current node's value to the sum for this depth.
            depth_sums[depth] += node.val
            
            # Go deeper into the tree for the left child, increasing the depth by 1.
            dfs_sum_values(node.left, depth + 1)
            # Go deeper into the tree for the right child, increasing the depth by 1.
            dfs_sum_values(node.right, depth + 1)

        # Helper function to perform DFS and replace the values of non-root nodes.
        def dfs_replace_values(node, depth):
            # If the node is None, we don't need to do anything (stop here).
            if node is None:
                return
            
            # Calculate the sum of values of the current node's children.
            # If a child doesn't exist, we consider its value as 0.
            children_sum = (node.left.val if node.left else 0) + (node.right.val if node.right else 0)
            
            # Replace the values of the left and right children.
            # We set their value to the total sum at this depth minus their own values.
            if node.left:
                node.left.val = depth_sums[depth] - children_sum
            if node.right:
                node.right.val = depth_sums[depth] - children_sum
            
            # Continue replacing values for the left and right children, going deeper.
            dfs_replace_values(node.left, depth + 1)
            dfs_replace_values(node.right, depth + 1)

        # This list will store the sums of values for nodes at each depth level.
        depth_sums = []
        
        # First, we calculate the sums at each depth starting from the root.
        dfs_sum_values(root, 0)
        
        # Set the root value to 0 because it doesn't have cousins.
        root.val = 0
        
        # Now we replace the values of the non-root nodes.
        dfs_replace_values(root, 1)
        
        # Return the modified tree with updated values.
        return root