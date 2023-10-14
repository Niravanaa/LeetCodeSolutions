public class Solution {
    public int MinCostConnectPoints(int[][] points) {
        int n = points.Length; // n is the number of points in the array

        // Create a list of all possible edges between points with their distances
        List<Edge> edges = new List<Edge>();
        for (int i = 0; i < n; i++) {
            for (int j = i + 1; j < n; j++) {
                // Calculate the distance between two points (Manhattan distance)
                int dist = Math.Abs(points[i][0] - points[j][0]) + Math.Abs(points[i][1] - points[j][1]);
                edges.Add(new Edge(i, j, dist));
            }
        }

        // Sort the edges by their distances
        edges.Sort((a, b) => a.Weight - b.Weight);

        // Initialize a data structure for disjoint sets (each point in its own set)
        int[] parent = new int[n];
        for (int i = 0; i < n; i++) {
            parent[i] = i;
        }

        int minCost = 0; // Initialize the minimum cost to zero
        int edgeCount = 0; // Initialize the count of edges to zero

        // Iterate through sorted edges
        foreach (Edge edge in edges) {
            // Find the parent (representative) of each set to which the two points belong
            int root1 = Find(parent, edge.Vertex1);
            int root2 = Find(parent, edge.Vertex2);

            // If the points are not in the same set (component), connect them
            if (root1 != root2) {
                // Connect the two components and add the edge's weight to the total cost
                parent[root1] = root2;
                minCost += edge.Weight;
                edgeCount++;
            }

            // If we have connected all points (edges), exit the loop
            if (edgeCount == n - 1) {
                break;
            }
        }

        return minCost; // Return the minimum cost to connect all points
    }
    
    // Find operation for disjoint sets
    private int Find(int[] parent, int x) {
        if (parent[x] != x) {
            // If a point's parent is not itself, recursively find the root parent
            parent[x] = Find(parent, parent[x]);
        }
        return parent[x]; // Return the root parent of the set
    }
}

public class Edge {
    public int Vertex1 { get; }
    public int Vertex2 { get; }
    public int Weight { get; }

    public Edge(int v1, int v2, int weight) {
        Vertex1 = v1;
        Vertex2 = v2;
        Weight = weight;
    }
}
