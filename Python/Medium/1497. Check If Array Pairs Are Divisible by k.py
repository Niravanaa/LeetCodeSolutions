class Solution:
    def canArrange(self, arr: List[int], k: int) -> bool:
        remainder_count = [0] * k

        for num in arr:
            remainder_count[num % k] += 1

        for r in range(1, (k // 2) + 1):
            if remainder_count[r] != remainder_count[k - r]:
                return False

        if remainder_count[0] % 2 != 0:
            return False

        return True