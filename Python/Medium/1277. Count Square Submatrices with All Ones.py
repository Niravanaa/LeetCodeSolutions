class Solution:
    def countSquares(self, matrix: List[List[int]]) -> int:
        if not matrix:
            return 0
            
        m, n = len(matrix), len(matrix[0])
        dp = [[0] * n for _ in range(m)]
        total_squares = 0
        
        for i in range(m):
            for j in range(n):
                if matrix[i][j] == 1:
                    # If we're at the first row or first column, we can only have squares of size 1
                    if i == 0 or j == 0:
                        dp[i][j] = 1
                    else:
                        # Calculate the size of the square based on the min of top, left, and top-left
                        dp[i][j] = min(dp[i-1][j], dp[i][j-1], dp[i-1][j-1]) + 1
                    # Add the number of squares ending at (i, j) to the total
                    total_squares += dp[i][j]

        return total_squares