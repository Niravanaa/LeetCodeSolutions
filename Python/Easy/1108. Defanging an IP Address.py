class Solution:
    def defangIPaddr(self, address: str) -> str:
        result = ""

        for character in address:
            if character == '.':
                result += "[.]"
            else:
                result += character
        
        return result
