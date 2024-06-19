class Solution:
    def findComplement(self, num: int) -> int:
        num_bits = num.bit_length()
    
        # Create a mask of the same length as num but with all bits set to 1
        mask = (1 << num_bits) - 1
        
        # XOR num with the mask to flip all the bits
        complement = num ^ mask
        
        return complement