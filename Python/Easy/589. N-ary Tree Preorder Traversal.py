class Solution:
    def preorder(self, root: 'Node') -> List[int]:
        if root is None:
            return []

        result = [root.val]

        for child in root.children:
            if child is not None:
                result.extend(self.preorder(child))

        return result