class Solution:
    def largestTriangleArea(self, points: List[List[int]]) -> float:
        def triangle_area(p1, p2, p3):
            x1, y1 = p1
            x2, y2 = p2
            x3, y3 = p3
            return 0.5 * abs(x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2))
        
        max_area = 0
        for p1, p2, p3 in combinations(points, 3):
            max_area = max(max_area, triangle_area(p1, p2, p3))
        
        return max_area