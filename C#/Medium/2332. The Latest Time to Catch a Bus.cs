public class Solution {
    public int BinarySearch(int[] array, int left, int target) {
        int right = array.Length;
        
        while (left < right) 
        {
            int mid = (right + left) / 2;

            if (mid >= array.Length) 
            {
                return mid;
            }

            if (array[mid] <= target) 
            {
                left = mid + 1;
            } 
            
            else 
            {
                right = mid;
            }
        }

        return left;
    }

    public int LatestTimeCatchTheBus(int[] buses, int[] passengers, int capacity) 
    {
        Array.Sort(buses);

        Array.Sort(passengers);

        int n = buses.Length;

        int m = passengers.Length;

        Dictionary<int, bool> occur = new Dictionary<int, bool>();

        foreach (int p in passengers) 
        {
            occur[p] = true;
        }

        int left = -1;
        bool lastBusNotFull = false;

        for (int i = 0; i < n; i++) 
        {
            int index = BinarySearch(passengers, left + 1, buses[i]);

            int newPassengers = index - left - 1;

            if (newPassengers >= capacity) 
            {
                newPassengers = capacity;
            } 
            
            else if (i == n - 1) 
            {
                lastBusNotFull = true;
            }

            left += newPassengers;
        }

        if (left == -1) 
        {
            return buses[n - 1];
        }

        int possible = passengers[left] - 1;

        if (lastBusNotFull) 
        {
            possible = buses[n - 1];
        }

        while (true) 
        {
            if (occur.ContainsKey(possible)) 
            {
                possible--;
            } 
            
            else 
            {
                break;
            }
        }

        return possible;
    }
}