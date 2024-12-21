from collections import defaultdict

class Solution:
    def maxKDivisibleComponents(self, n: int, edges: List[List[int]], values: List[int], k: int) -> int:
        graph = defaultdict(list)
        for a, b in edges:
            graph[a].append(b)
            graph[b].append(a)

        max_components = 0

        def dfs(node, parent):
            nonlocal max_components

            subtree_sum = values[node]

            for neighbor in graph[node]:
                if neighbor != parent:
                    child_sum = dfs(neighbor, node)
                    subtree_sum += child_sum

            if subtree_sum % k == 0:
                max_components += 1
                return 0
            
            return subtree_sum
        
        dfs(0, -1)

        return max_components