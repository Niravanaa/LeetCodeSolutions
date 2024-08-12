class Solution:
    def fairCandySwap(self, aliceSizes: List[int], bobSizes: List[int]) -> List[int]:
        sumAlice = sum(aliceSizes)
        sumBob = sum(bobSizes)

        diff = (sumAlice - sumBob) // 2

        bobSet = set(bobSizes)

        for candy in aliceSizes:
            if candy - diff in bobSet:
                return [candy, candy - diff]
        