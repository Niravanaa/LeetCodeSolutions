public class Solution {
    public bool IsPowerOfFour(int n) {
        if (n > 0 && (n & (n - 1)) == 0)
        {
            int countTrailingZeros = 0;

            while (n > 1)
            {
                n >>= 1;

                countTrailingZeros++;
            }

            return countTrailingZeros % 2 == 0;
        }

        return false;
    }
}