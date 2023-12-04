public class Solution {
    public int[] SortByBits(int[] arr) {
        Array.Sort(arr, (a, b) =>
        {
            int countA = CountBits(a);
            int countB = CountBits(b);

            if (countA == countB) {
                return a.CompareTo(b);
            }

            return countA.CompareTo(countB);
        });

        return arr;
    }

    private int CountBits(int num) {
        int count = 0;
        while (num > 0) {
            if ((num & 1) == 1) {
                count++;
            }
            num >>= 1;
        }
        return count;
    }
}
