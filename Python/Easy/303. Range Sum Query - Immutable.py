class NumArray:
    def __init__(self, nums: List[int]):
        self.prefix_nums = [0] * (len(nums) + 1)
        for i in range(len(nums)):
            self.prefix_nums[i + 1] = self.prefix_nums[i] + nums[i]

    def sumRange(self, left: int, right: int) -> int:
        return self.prefix_nums[right + 1] - self.prefix_nums[left]