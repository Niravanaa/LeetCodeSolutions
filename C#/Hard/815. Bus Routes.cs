public class Solution {
    public int NumBusesToDestination(int[][] routes, int source, int target) {
        if (source == target) return 0;

        Dictionary<int, List<int>> stopToRoutes = new Dictionary<int, List<int>>();

        for (int i = 0; i < routes.Length; i++)
        {
            foreach (int stop in routes[i])
            {
                if (!stopToRoutes.ContainsKey(stop))
                {
                    stopToRoutes[stop] = new List<int>();
                }
                stopToRoutes[stop].Add(i);
            }
        }

        Queue<int> queue = new Queue<int>();
        HashSet<int> visitedStops = new HashSet<int>();
        HashSet<int> visitedRoutes = new HashSet<int>();

        queue.Enqueue(source);
        visitedStops.Add(source);

        int buses = 0;

        while (queue.Count > 0)
        {
            int stopsInCurrentLevel = queue.Count;

            for (int i = 0; i < stopsInCurrentLevel; i++)
            {
                int currentStop = queue.Dequeue();

                if (stopToRoutes.ContainsKey(currentStop))
                {
                    foreach (int routeIndex in stopToRoutes[currentStop])
                    {
                        if (!visitedRoutes.Contains(routeIndex))
                        {
                            visitedRoutes.Add(routeIndex);

                            foreach (int nextStop in routes[routeIndex])
                            {
                                if (!visitedStops.Contains(nextStop))
                                {
                                    if (nextStop == target)
                                    {
                                        return buses + 1;
                                    }

                                    queue.Enqueue(nextStop);
                                    visitedStops.Add(nextStop);
                                }
                            }
                        }
                    }
                }
            }

            buses++;
        }

        return -1;
    }
}