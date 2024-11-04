class Solution:
    def makeFancyString(self, s: str) -> str:
        # Initialize a new result string
        result = []
        
        # Iterate through the input string
        for char in s:
            # If result has less than 2 characters or last two characters are not the same
            if len(result) < 2 or not (result[-1] == char and result[-2] == char):
                result.append(char)

        # Join the result list into a string and return it
        return ''.join(result)