class Solution:
    def isBoomerang(self, points: List[List[int]]) -> bool:
        def are_distinct(p1, p2, p3):
            return p1 != p2 and p2 != p3 and p1 != p3

        def are_collinear(p1, p2, p3):
            x1, y1 = p1
            x2, y2 = p2
            x3, y3 = p3
            # Compute the determinant to check for collinearity
            return (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) == 0
        
        # Check if the points are distinct and not collinear
        p1, p2, p3 = points
        return (are_distinct(p1, p2, p3) and not are_collinear(p1, p2, p3))
