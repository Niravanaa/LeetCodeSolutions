class Solution:
    def findTarget(self, root: Optional[TreeNode], k: int) -> bool:
        def inorder(node: Optional[TreeNode], seen: Set[int]) -> bool:
            if not node:
                return False
            
            if inorder(node.left, seen):
                return True
            
            if k - node.val in seen:
                return True
            seen.add(node.val)
            
            return inorder(node.right, seen)
        
        return inorder(root, set())