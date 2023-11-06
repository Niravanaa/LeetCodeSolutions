public class Solution {
    public int GetLastMoment(int n, int[] left, int[] right) {
        List<int> antFallingTimes = new List<int>();

        for (int i = 0; i < left.Length; i++)
        {
            antFallingTimes.Add(left[i]);
        }

        for (int i = 0; i < right.Length; i++)
        {
            antFallingTimes.Add(n - right[i]);
        }

        return antFallingTimes.Max();
    }
}