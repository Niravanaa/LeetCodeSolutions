class Solution:
    def countBinarySubstrings(self, s: str) -> int:
        count = 0
        prev_length = 0
        current_length = 1
        
        for i in range(1, len(s)):
            if s[i] == s[i-1]:
                current_length += 1
            else:
                prev_length = current_length
                current_length = 1
                
            if prev_length >= current_length:
                count += 1
        
        return count