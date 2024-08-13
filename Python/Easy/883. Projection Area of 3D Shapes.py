class Solution:
    def projectionArea(self, grid: List[List[int]]) -> int:
        top_view = sum(v > 0 for row in grid for v in row)

        front_view = sum(max(row) for row in grid)

        side_view = sum(max(col) for col in zip(*grid))

        return top_view + front_view + side_view