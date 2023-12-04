public class Graph
{
    private Dictionary<int, List<int[]>> adjacencyList;

    public Graph(int n, int[][] edges)
    {
        adjacencyList = new Dictionary<int, List<int[]>>();

        for (int i = 0; i < n; i++)
        {
            adjacencyList[i] = new List<int[]>();
        }

        foreach (var edge in edges)
        {
            int from = edge[0];
            int to = edge[1];
            int cost = edge[2];
            adjacencyList[from].Add(new int[] { to, cost });
        }
    }

    public void AddEdge(int[] edge)
    {
        int from = edge[0];
        int to = edge[1];
        int cost = edge[2];
        adjacencyList[from].Add(new int[] { to, cost });
    }

    public int ShortestPath(int node1, int node2)
    {
        PriorityQueue<int[]> priorityQueue = new PriorityQueue<int[]>(Comparer<int[]>.Create((a, b) => a[1].CompareTo(b[1])));
        Dictionary<int, int> distance = new Dictionary<int, int>();

        priorityQueue.Enqueue(new int[] { node1, 0 });
        distance[node1] = 0;

        while (priorityQueue.Count > 0)
        {
            int[] current = priorityQueue.Dequeue();
            int currentNode = current[0];
            int currentCost = current[1];

            if (currentNode == node2)
            {
                return currentCost;
            }

            if (distance.ContainsKey(currentNode) && distance[currentNode] < currentCost)
            {
                continue;
            }

            foreach (var neighbor in adjacencyList[currentNode])
            {
                int neighborNode = neighbor[0];
                int neighborCost = neighbor[1];
                int newCost = currentCost + neighborCost;

                if (!distance.ContainsKey(neighborNode) || newCost < distance[neighborNode])
                {
                    distance[neighborNode] = newCost;
                    priorityQueue.Enqueue(new int[] { neighborNode, newCost });
                }
            }
        }

        return -1;
    }
}

public class PriorityQueue<T>
{
    private List<T> heap;
    private Comparer<T> comparer;

    public PriorityQueue(Comparer<T> comparer)
    {
        this.heap = new List<T>();
        this.comparer = comparer;
    }

    public int Count
    {
        get { return heap.Count; }
    }

    public void Enqueue(T item)
    {
        heap.Add(item);
        int currentIndex = heap.Count - 1;

        while (currentIndex > 0)
        {
            int parentIndex = (currentIndex - 1) / 2;

            if (comparer.Compare(heap[currentIndex], heap[parentIndex]) >= 0)
            {
                break;
            }

            Swap(currentIndex, parentIndex);
            currentIndex = parentIndex;
        }
    }

    public T Dequeue()
    {
        if (heap.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        T result = heap[0];
        heap[0] = heap[heap.Count - 1];
        heap.RemoveAt(heap.Count - 1);

        int currentIndex = 0;

        while (true)
        {
            int leftChildIndex = currentIndex * 2 + 1;
            int rightChildIndex = currentIndex * 2 + 2;

            if (leftChildIndex >= heap.Count)
            {
                break;
            }

            int smallerChildIndex = leftChildIndex;
            if (rightChildIndex < heap.Count && comparer.Compare(heap[rightChildIndex], heap[leftChildIndex]) < 0)
            {
                smallerChildIndex = rightChildIndex;
            }

            if (comparer.Compare(heap[currentIndex], heap[smallerChildIndex]) <= 0)
            {
                break;
            }

            Swap(currentIndex, smallerChildIndex);
            currentIndex = smallerChildIndex;
        }

        return result;
    }

    private void Swap(int index1, int index2)
    {
        T temp = heap[index1];
        heap[index1] = heap[index2];
        heap[index2] = temp;
    }
}