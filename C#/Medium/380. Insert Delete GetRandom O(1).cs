public class RandomizedSet {
    HashSet<int> set;

    public RandomizedSet() {
        set = new HashSet<int>();
    }
    
    public bool Insert(int val) {
        if (set.Contains(val))
        {
            return false;
        }

        else
        {
            set.Add(val);
            return true;
        }
    }
    
    public bool Remove(int val) {
        if (!set.Contains(val))
        {
            return false;
        }        

        else
        {
            set.Remove(val);
            return true;
        }
    }
    
    public int GetRandom() {
        Random random = new Random();

        return set.ElementAt(random.Next(set.Count));
    }
}