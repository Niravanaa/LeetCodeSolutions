public class Solution {
    public int MySqrt(int x) {
        // For 0 and 1, the square roots are themselves
        if (x < 2)
            return x;
        
        double y = x;
        double z = (y + (x / y)) / 2;
        
        // We want to approximate the square root with 5 decimal digits accuracy,
        // so the absolute difference should not exceed 0.00001
        while (Math.Abs(y - z) >= 0.00001) {
            y = z;
            z = (y + (x / y)) / 2;
        }
        
        return (int)z;
    }
}
