class Solution:
    def binaryGap(self, n: int) -> int:
        binary_repr = bin(n)[2:]

        ones_indices = [i for i, bit in enumerate(binary_repr) if bit == '1']

        if len(ones_indices) < 2:
            return 0
        
        max_gap = max(ones_indices[i + 1] - ones_indices[i] for i in range(len(ones_indices) - 1))

        return max_gap