class Solution:
    def findKthBit(self, n: int, k: int) -> str:
        def get_length(i):
            return 2**i - 1

        if k == 1:
            return "0"

        length = get_length(n)
        
        while n > 1:
            mid = (length + 1) // 2
            
            if k == mid:
                return "1"
            elif k < mid:
                n -= 1
                length = get_length(n)
            else:
                k = length - k + 1
                n -= 1
                length = get_length(n)
                return "0" if self.findKthBit(n, k) == "1" else "1"
        
        return "0"
