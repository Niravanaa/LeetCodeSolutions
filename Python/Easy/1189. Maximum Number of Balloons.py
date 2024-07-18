class Solution:
    def maxNumberOfBalloons(self, text: str) -> int:
        char_count = Counter(text)
    
        # Define the character requirements for the word "balloon"
        balloon_count = Counter("balloon")
        
        # Initialize the maximum number of instances to a large value
        max_instances = float('inf')
        
        # Determine the limiting factor for forming "balloon"
        for char in balloon_count:
            max_instances = min(max_instances, char_count[char] // balloon_count[char])
        
        return max_instances