class Solution:
    def findTheLongestSubstring(self, s: str) -> int:
        vowel_to_bit = {'a': 0, 'e': 1, 'i': 2, 'o': 3, 'u': 4}

        mask = 0

        mask_to_index = {0: -1}
        longest = 0

        for i, char in enumerate(s):
            if char in vowel_to_bit:
                mask ^= (1 << vowel_to_bit[char])

            if mask in mask_to_index:
                longest = max(longest, i - mask_to_index[mask])
            else:
                mask_to_index[mask] = i

        return longest