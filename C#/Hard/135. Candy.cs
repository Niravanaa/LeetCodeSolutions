public class Solution {
    public int Candy(int[] ratings) {
        int[] candies = new int[ratings.Length];

        for (int i = 0; i < candies.Length; i++) {
            candies[i] = 1;
        }

        for (int i = 1; i < ratings.Length; i++) {
            if (ratings[i] > ratings[i - 1]) {
                candies[i] = candies[i - 1] + 1;
            }
        }

        for (int i = ratings.Length - 2; i >= 0; i--) {
            if (ratings[i] > ratings[i + 1] && candies[i] <= candies[i + 1]) {
                candies[i] = candies[i + 1] + 1;
            }
        }

        int totalCandies = 0;
        foreach (int candyCount in candies) {
            totalCandies += candyCount;
        }

        return totalCandies;
    }
}
