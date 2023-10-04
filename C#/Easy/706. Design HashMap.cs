public class MyHashMap
{
    private int[] keys;
    private int[] values;

    public MyHashMap()
    {
        keys = new int[1000001]; // Assuming keys are integers in the range [0, 1000000]
        values = new int[1000001]; // Initialize with a specific size
    }

    public void Put(int key, int value)
    {
        keys[key] = key;
        values[key] = value;
    }

    public int Get(int key)
    {
        return keys[key] == key ? values[key] : -1;
    }

    public void Remove(int key)
    {
        keys[key] = -1; // Mark the key as removed
    }
}
