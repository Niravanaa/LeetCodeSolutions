class Solution(object):
    def middleNode(self, head):
        nodes = []

        current = head

        while current is not None:
            nodes.append(current)
            current = current.next

        halfwayPoint = len(nodes) // 2

        return nodes[halfwayPoint]