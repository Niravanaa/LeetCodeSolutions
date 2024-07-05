class Solution:
    def canPlaceFlowers(self, flowerbed: List[int], n: int) -> bool:
        # Add padding zeros to handle edge cases easily
        flowerbed = [0] + flowerbed + [0]
        count = 0
        
        # Iterate through the flowerbed
        for i in range(1, len(flowerbed) - 1):
            # Check if the current plot and its adjacent plots are empty
            if flowerbed[i-1] == 0 and flowerbed[i] == 0 and flowerbed[i+1] == 0:
                flowerbed[i] = 1  # Plant a flower here
                count += 1
                if count >= n:
                    return True
        
        # If we cannot plant enough flowers, return False
        return count >= n