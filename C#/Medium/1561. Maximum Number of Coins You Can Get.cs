public class Solution {
    public int MaxCoins(int[] piles) {
        Array.Sort(piles);
        
        int result = 0;
        int left = 0;
        int right = piles.Length - 1;
        
        while (left < right) {
            result += piles[right - 1];
            left++;
            right -= 2;
        }
        
        return result;
    }
}
