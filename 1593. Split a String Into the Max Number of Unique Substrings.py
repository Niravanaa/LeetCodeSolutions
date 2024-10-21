class Solution:
    def maxUniqueSplit(self, s: str) -> int:
        def backtrack(start_index, unique_count):
            if (start_index >= len(s)):
                nonlocal max_substrings
                max_substrings = max(max_substrings, unique_count)
                return
            for end_index in range(start_index + 1, len(s) + 1):
                if s[start_index:end_index] not in seen_substrings:
                    seen_substrings.add(s[start_index:end_index])
                    backtrack(end_index, unique_count + 1)
                    seen_substrings.remove(s[start_index:end_index])

        seen_substrings = set()

        max_substrings = 0

        backtrack(0, 0)

        return max_substrings
