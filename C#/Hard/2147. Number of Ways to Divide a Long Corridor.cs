public class Solution 
{
    private const int Mod = 1000000007;
    
    public int NumberOfWays(string corridor) 
    {
        int waysToReachCurrentPosition = 1;
        int waysToReachPreviousPosition = 0;
        int waysToReachTwoPositionsBefore = 0;

        foreach (var section in corridor)
        {
            waysToReachCurrentPosition = (waysToReachCurrentPosition + waysToReachTwoPositionsBefore) % Mod;

            if (section == 'S')
            {
                waysToReachTwoPositionsBefore = waysToReachPreviousPosition;
                waysToReachPreviousPosition = waysToReachCurrentPosition;
                waysToReachCurrentPosition = 0;
            }
        }

        return waysToReachTwoPositionsBefore;
    }
}
