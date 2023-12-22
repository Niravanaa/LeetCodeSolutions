public class Solution {
    public int MaxWidthOfVerticalArea(int[][] points) {
        Array.Sort(points, (a, b) => a[0] - b[0]);
        int maxWidth = 0;
        
        for (int i = 1; i < points.Length; i++) {
            maxWidth = Math.Max(maxWidth, points[i][0] - points[i - 1][0]);
        }
        
        return maxWidth;
    }
}