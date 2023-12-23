public class Solution {
    public bool IsPathCrossing(string path) {
        HashSet<(int, int)> coordinateSet = new HashSet<(int, int)>();

        int currentX = 0;
        int currentY = 0;

        coordinateSet.Add((0, 0));

        for (int i = 0; i < path.Length; i++)
        {
            switch(path[i])
            {
                case 'N':
                    currentY++;
                    break;
                
                case 'S':
                    currentY--;
                    break;
                
                case 'E':
                    currentX++;
                    break;
                
                case 'W':
                    currentX--;
                    break;
            }
            
            if (coordinateSet.Contains((currentX, currentY)))
            {
                return true;
            }

            coordinateSet.Add((currentX, currentY));
        }

        return false;
    }
}