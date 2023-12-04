public class Solution {
    public int GetWinner(int[] arr, int k) {
        int n = arr.Length;
        if (k >= n - 1) {
            return arr.Max();
        }

        int current_winner = arr[0];
        int win_count = 0;

        for (int i = 1; i < n; i++) {
            if (arr[i] > current_winner) {
                current_winner = arr[i];
                win_count = 1;
            } else {
                win_count++;
            }

            if (win_count == k) {
                return current_winner;
            }
        }

        return current_winner;
    }
}
