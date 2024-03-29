public class 1103. Distribute Candies to People {
    
}
class Solution {
    public int[] distributeCandies(int candies, int num_people) {
        int[] distribution = new int[num_people];
        int i = 0;
        int candy = 1;

        while (candies > 0) {
            distribution[i % num_people] += Math.min(candies, candy);
            candies -= candy;
            candy++;
            i++;
        }

        return distribution;
    }
}