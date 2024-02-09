public class MaxHeap<T> where T : IComparable<T>
{
    private List<T> heap;

    public MaxHeap()
    {
        heap = new List<T>();
    }

    public int Count
    {
        get { return heap.Count; }
    }

    public void Insert(T item)
    {
        heap.Add(item);
        HeapifyUp(heap.Count - 1);
    }

    public T ExtractMax()
    {
        if (heap.Count == 0)
            throw new InvalidOperationException("Heap is empty");

        T max = heap[0];
        heap[0] = heap[heap.Count - 1];
        heap.RemoveAt(heap.Count - 1);
        HeapifyDown(0);

        return max;
    }

    private void HeapifyUp(int index)
    {
        while (index > 0)
        {
            int parentIndex = (index - 1) / 2;
            if (heap[index].CompareTo(heap[parentIndex]) <= 0)
                break;

            Swap(index, parentIndex);
            index = parentIndex;
        }
    }

    private void HeapifyDown(int index)
    {
        while (true)
        {
            int leftChildIndex = 2 * index + 1;
            int rightChildIndex = 2 * index + 2;
            int largestIndex = index;

            if (leftChildIndex < heap.Count && heap[leftChildIndex].CompareTo(heap[largestIndex]) > 0)
                largestIndex = leftChildIndex;

            if (rightChildIndex < heap.Count && heap[rightChildIndex].CompareTo(heap[largestIndex]) > 0)
                largestIndex = rightChildIndex;

            if (largestIndex == index)
                break;

            Swap(index, largestIndex);
            index = largestIndex;
        }
    }

    private void Swap(int i, int j)
    {
        T temp = heap[i];
        heap[i] = heap[j];
        heap[j] = temp;
    }
}

public class Solution {
    public int LastStoneWeight(int[] stones) {
        MaxHeap<int> stoneValues = new MaxHeap<int>();

        foreach (int value in stones)
        {
            stoneValues.Insert(value);
        }

        while (stoneValues.Count > 1)
        {
            int first = stoneValues.ExtractMax();
            int second = stoneValues.ExtractMax();

            if (first != second)
            {
                stoneValues.Insert(first - second);
            }
        }

        return stoneValues.Count == 0 ? 0 : stoneValues.ExtractMax();
    }
}