class Solution:
    def surfaceArea(self, grid: List[List[int]]) -> int:
        n = len(grid)
        surface_area = 0
        
        for i in range(n):
            for j in range(n):
                if grid[i][j] > 0:
                    surface_area += 2
                    surface_area += max(grid[i][j] - grid[i-1][j], 0) if i > 0 else grid[i][j]
                    surface_area += max(grid[i][j] - grid[i+1][j], 0) if i < n-1 else grid[i][j]
                    surface_area += max(grid[i][j] - grid[i][j-1], 0) if j > 0 else grid[i][j]
                    surface_area += max(grid[i][j] - grid[i][j+1], 0) if j < n-1 else grid[i][j]
        
        return surface_area