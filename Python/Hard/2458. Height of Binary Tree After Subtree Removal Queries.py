from collections import defaultdict

# Definition for a binary tree node.
class TreeNode:
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right


class Solution:
    def treeQueries(self, root: Optional[TreeNode], queries: List[int]) -> List[int]:
        # Helper function to calculate the depth of the tree
        def calculate_depth(node):
            if node is None:
                return 0

            # Recursively find the depth of the left and right subtrees
            left_depth, right_depth = calculate_depth(node.left), calculate_depth(node.right)
            
            # Store the depth of the current node
            depth_dict[node] = 1 + max(left_depth, right_depth)

            return depth_dict[node]

        # Perform a Depth-First Search to find the highest visible value from each node
        def dfs(node, current_depth, max_visible_value):

            if node is None:
                return

            current_depth += 1

            # Record the maximum visible value for the current node
            results[node.val] = max_visible_value

            # Explore the left and right subtrees
            dfs(node.left, current_depth, max(max_visible_value, current_depth + depth_dict[node.right]))
            dfs(node.right, current_depth, max(max_visible_value, current_depth + depth_dict[node.left]))

        # Dictionary to hold the depth of each node
        depth_dict = defaultdict(int)
        
        # Calculate the depth of each node in the tree
        calculate_depth(root)

        # Initialize the results list with zeros for each value up to the number of nodes
        results = [0] * (len(depth_dict) + 1)

        # Start the DFS from the root node
        dfs(root, -1, 0)

        # Create the list of results for each query
        return [results[value] for value in queries]