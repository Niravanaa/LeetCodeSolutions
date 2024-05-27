class Solution(object):
    def divideString(self, s, k, fill):
        """
        :type s: str
        :type k: int
        :type fill: str
        :rtype: List[str]
        """
        result = []  # Initialize an empty list to store the resulting chunks.

        # Loop through the string in steps of k.
        for i in range(0, len(s), k):
            group = s[i:i+k]  # Extract a substring of length k.
            if len(group) < k:
                # If the substring is shorter than k, append the fill character to make its length k.
                group += fill * (k - len(group))
            result.append(group)  # Add the chunk to the result list.

        return result  # Return the list of chunks.
