public class Solution {
    public int EliminateMaximum(int[] dist, int[] speed) {
        List<(int, int)> monsters = new List<(int, int)>();

        int n = dist.Length;

        for (int i = 0; i < n; i++)
        {
            int timeToReachCity = (int)Math.Ceiling((double)dist[i] / speed[i]);

            monsters.Add((timeToReachCity, i));
        }

        monsters.Sort();

        int eliminatedMonsters = 0;

        int currentTime = 1;

        foreach ((int timeToReachCity, int index) in monsters)
        {
            if (currentTime <= timeToReachCity)
            {
                Console.WriteLine(currentTime + " and " + timeToReachCity);

                eliminatedMonsters++;

                currentTime++;
            }

            else
            {
                break;
            }
        }

        return eliminatedMonsters;
    }
}