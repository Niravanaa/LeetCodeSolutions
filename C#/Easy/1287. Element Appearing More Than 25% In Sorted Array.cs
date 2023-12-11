public class Solution {
    public int FindSpecialInteger(int[] arr) {
        Dictionary<int, int> freqDict = new Dictionary<int, int>();

        foreach (int num in arr)
        {
            if (freqDict.ContainsKey(num))
            {
                freqDict[num]++;

                continue;
            }

            freqDict.Add(num, 1);
        }
        
        int result = 0;

        foreach (int num in freqDict.Keys)
        {
            if ((double)freqDict[num] > arr.Length * 0.25)
            {
                result = num;

                break;
            }
        }

        return result;
    }
}