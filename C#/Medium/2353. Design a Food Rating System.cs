public class FoodRatings {
private Dictionary<string, string> map;

    private Dictionary<string, PriorityQueue<(int r, string f, int t), (int r, string f, int t)>> items;

    private Dictionary<string, int> time;

    private int t;

    public FoodRatings(string[] foods, string[] cuisines, int[] ratings) {
        this.map = new();
        this.items = new();
        this.time = new();

        // initial t = 0
        int n = foods.Length;
        for(int i = 0; i < n; i++)
        {
            this.map.Add(foods[i], cuisines[i]);
            this.time.Add(foods[i], 0);
            if (this.items.ContainsKey(cuisines[i]) == false)
            {
                this.items.Add(cuisines[i], new());
            }
            this.items[cuisines[i]].Enqueue((-ratings[i], foods[i], 0), (-ratings[i], foods[i], 0));
        }

        this.t = -1;
    }
    
    public void ChangeRating(string food, int newRating) {

        var que = this.items[this.map[food]];
        que.Enqueue((-newRating, food, this.t), (-newRating, food, this.t));

        this.time[food] = this.t;
        this.t--;
    }
    
    public string HighestRated(string cuisine) {
        var que = this.items[cuisine];

        while (que.Count > 0)
        {
            (int _, string f, int t) = que.Peek();
            if (this.time[f] != t)
            {
                que.Dequeue();
            }
            else
            {
                return f;
            }
        }

        return string.Empty;
    }
}

/**
 * Your FoodRatings object will be instantiated and called as such:
 * FoodRatings obj = new FoodRatings(foods, cuisines, ratings);
 * obj.ChangeRating(food,newRating);
 * string param_2 = obj.HighestRated(cuisine);
 */