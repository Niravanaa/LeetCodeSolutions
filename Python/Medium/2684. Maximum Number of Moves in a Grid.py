class Solution:
    def maxMoves(self, grid: List[List[int]]) -> int:
        m, n = len(grid), len(grid[0])
        memo = [[-1] * n for _ in range(m)]

        def dfs(row: int, col: int) -> int:
            # If we've already computed the result for this cell, return it
            if memo[row][col] != -1:
                return memo[row][col]

            max_moves = 0
            # Explore possible moves to the next column
            if col < n - 1:  # Ensure we don't go out of bounds for the next column
                for new_row in (row - 1, row, row + 1):
                    if 0 <= new_row < m and grid[new_row][col + 1] > grid[row][col]:
                        max_moves = max(max_moves, 1 + dfs(new_row, col + 1))
            
            # Store the result in the memo table
            memo[row][col] = max_moves
            return max_moves

        max_total_moves = 0
        for i in range(m):
            max_total_moves = max(max_total_moves, dfs(i, 0))

        return max_total_moves
