public class Solution {
    public int[] RestoreArray(int[][] adjacentPairs) {
        Dictionary<int, List<int>> graph = BuildGraph(adjacentPairs);
        int start = FindStartNode(graph);

        List<int> result = new List<int>();
        HashSet<int> visited = new HashSet<int>();
        DFS(graph, start, visited, result);

        return result.ToArray();
    }

    static Dictionary<int, List<int>> BuildGraph(int[][] adjacentPairs)
    {
        Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();

        foreach (var pair in adjacentPairs)
        {
            if (!graph.ContainsKey(pair[0]))
                graph[pair[0]] = new List<int>();

            if (!graph.ContainsKey(pair[1]))
                graph[pair[1]] = new List<int>();

            graph[pair[0]].Add(pair[1]);
            graph[pair[1]].Add(pair[0]);
        }

        return graph;
    }

    static int FindStartNode(Dictionary<int, List<int>> graph)
    {
        foreach (var entry in graph)
        {
            if (entry.Value.Count == 1)
                return entry.Key;
        }

        return -1;
    }

    static void DFS(Dictionary<int, List<int>> graph, int current, HashSet<int> visited, List<int> result)
    {
        visited.Add(current);
        result.Add(current);

        foreach (var neighbor in graph[current])
        {
            if (!visited.Contains(neighbor))
                DFS(graph, neighbor, visited, result);
        }
    }
}

class TreeNode
{
    public int Value { get; set; }
    public TreeNode Left { get; set; }
    public TreeNode Right { get; set; }

    public TreeNode(int value)
    {
        Value = value;
        Left = null;
        Right = null;
    }
}