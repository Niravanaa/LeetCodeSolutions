import math

class Solution:
    def constructRectangle(self, area: int) -> List[int]:
        # Start from the largest possible W
        W = int(math.isqrt(area))
        
        # Iterate downwards to find the appropriate W
        while W > 0:
            if area % W == 0:
                L = area // W
                return [L, W]
            W -= 1