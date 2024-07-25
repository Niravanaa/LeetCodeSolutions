class Solution:
    def floodFill(self, image: List[List[int]], sr: int, sc: int, color: int) -> List[List[int]]:
        # Get the initial color
        initial_color = image[sr][sc]
    
        # If the initial color is the same as the new color, no changes are needed
        if initial_color == color:
            return image
        
        # Define the function to perform the flood fill
        def dfs(x, y):
            # If the pixel is out of bounds or not the same as the initial color, return
            if x < 0 or x >= len(image) or y < 0 or y >= len(image[0]) or image[x][y] != initial_color:
                return
            
            # Change the color of the current pixel
            image[x][y] = color
            
            # Recursively call dfs on the neighboring pixels
            dfs(x + 1, y)
            dfs(x - 1, y)
            dfs(x, y + 1)
            dfs(x, y - 1)
        
        # Start the flood fill from the starting pixel
        dfs(sr, sc)
        
        return image