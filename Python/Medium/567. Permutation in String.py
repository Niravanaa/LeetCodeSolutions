class Solution:
    def checkInclusion(self, s1: str, s2: str) -> bool:
        # Lengths of s1 and s2
        len_s1, len_s2 = len(s1), len(s2)

        # If s1 is longer than s2, it's impossible for s2 to contain a permutation of s1
        if len_s1 > len_s2:
            return False

        # Count the frequency of characters in s1
        s1_count = Counter(s1)

        # Create a count for the first window of s2
        window_count = Counter(s2[:len_s1])

        # Check if the first window is a permutation
        if s1_count == window_count:
            return True

        # Sliding window: move the window one character at a time
        for i in range(len_s1, len_s2):
            # Include the new character to the window
            window_count[s2[i]] += 1

            # Remove the oldest character from the window
            left_char = s2[i - len_s1]
            window_count[left_char] -= 1

            # If the count becomes zero, remove it from the Counter
            if window_count[left_char] == 0:
                del window_count[left_char]

            # Check if the current window is a permutation
            if s1_count == window_count:
                return True

        return False