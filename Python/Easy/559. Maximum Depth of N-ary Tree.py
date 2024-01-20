class Solution(object):
    def maxDepth(self, root):
        if not root:
            return 0

        if not root.children:
            return 1

        child_depths = [self.maxDepth(child) for child in root.children]
        return max(child_depths) + 1