class Solution:
    def distributeCandies(self, candyType: List[int]) -> int:
        unique_candies = len(set(candyType))

        max_candies_to_eat = len(candyType) / 2

        return int(min(unique_candies, max_candies_to_eat))