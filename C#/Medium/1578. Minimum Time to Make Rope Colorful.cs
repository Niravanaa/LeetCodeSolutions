public class Solution {
    public int MinCost(string colors, int[] neededTime) {
        int n = colors.Length;
        char previousColor = ' ';
        int previousTime = 0;
        int currentCost = 0;
        int previousCost = 0;

        for (int i = 0; i < n; i++)
        {
            if (colors[i] == previousColor)
            {
                int currentMinTime = Math.Min(neededTime[i], previousTime);
                currentCost = currentMinTime + previousCost;
                previousTime = Math.Max(neededTime[i], previousTime);
            }

            else
            {
                currentCost = previousCost;
                previousColor = colors[i];
                previousTime = neededTime[i];
            }

            previousCost = currentCost;
        }

        return previousCost;
    }
}