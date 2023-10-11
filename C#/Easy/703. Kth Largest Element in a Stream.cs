using System;

public class KthLargest
{
    private int k;
    private int[] kLargest;
    private int count;

    public KthLargest(int k, int[] nums)
    {
        this.k = k;
        kLargest = new int[k];
        count = 0;

        // Initialize kLargest with the first k elements from nums (if available)
        foreach (int num in nums)
        {
            Add(num);
        }
    }

    public int Add(int val)
    {
        if (count < k)
        {
            InsertSorted(val);
        }
        else if (val > kLargest[0])
        {
            RemoveSmallest();
            InsertSorted(val);
        }

        return kLargest[0];
    }

    // Helper method to insert a value into the sorted kLargest array
    private void InsertSorted(int val)
    {
        int i = count - 1;
        while (i >= 0 && val < kLargest[i])
        {
            kLargest[i + 1] = kLargest[i];
            i--;
        }
        kLargest[i + 1] = val;
        count++;
    }

    // Helper method to remove the smallest element from kLargest
    private void RemoveSmallest()
    {
        for (int i = 0; i < k - 1; i++)
        {
            kLargest[i] = kLargest[i + 1];
        }
        count--;
    }
}
