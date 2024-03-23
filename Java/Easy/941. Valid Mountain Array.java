public class 941. Valid Mountain Array {
    
}
class Solution {
    public boolean validMountainArray(int[] arr) {
        int n = arr.length;
        if (n < 3) return false;

        int i = 0;

        // Walk up
        while (i + 1 < n && arr[i] < arr[i + 1]) {
            i++;
        }

        // Peak can't be first or last
        if (i == 0 || i == n - 1) {
            return false;
        }

        // Walk down
        while (i + 1 < n && arr[i] > arr[i + 1]) {
            i++;
        }

        return i == n - 1;
    }
}