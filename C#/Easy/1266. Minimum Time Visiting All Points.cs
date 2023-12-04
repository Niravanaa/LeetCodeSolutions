public class Solution {
    public int MinTimeToVisitAllPoints(int[][] points) 
    {
        int time = 0;

        for (int i = 0; i < points.Length - 1; i++) 
        {
            int deltaX = Math.Abs(points[i + 1][0] - points[i][0]);

            int deltaY = Math.Abs(points[i + 1][1] - points[i][1]);
            
            time += Math.Max(deltaX, deltaY);
        }

        return time;
    }
}
