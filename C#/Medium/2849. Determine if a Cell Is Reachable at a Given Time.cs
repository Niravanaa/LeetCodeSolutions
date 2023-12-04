public class Solution {
    public bool IsReachableAtTime(int sx, int sy, int fx, int fy, int t) {
        if (sx == fx && sy == fy)
        {
            return t == 0 || t > 1;
        }

        int d1 = Math.Abs(sy - fy);

        int d2 = Math.Abs(sx - fx);

        int minStep = Math.Min(d1, d2) + Math.Abs(d1 - d2);

        return minStep <= t;
    }
}
