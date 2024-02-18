public class MyHashSet
{

    private List<int> listSet;

    public MyHashSet()
    {
        listSet = new List<int>();
    }

    public void Add(int key)
    {
        if (!listSet.Contains(key))
        {
            listSet.Add(key);
        }
    }

    public void Remove(int key)
    {
        if (listSet.Contains(key))
        {
            listSet.Remove(key);
        }
    }

    public bool Contains(int key)
    {
        return listSet.Contains(key);
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */