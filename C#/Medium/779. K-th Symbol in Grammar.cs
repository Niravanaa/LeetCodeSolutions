public class Solution {
    public int KthGrammar(int n, int k) {
        if (n == 1) {
            return 0;
        }
        
        // Calculate the midpoint of the (n-1)th row
        int mid = (1 << (n - 2));
        
        if (k <= mid) {
            // If k is in the first half of the (n-1)th row, it's the same as KthGrammar(n-1, k)
            return KthGrammar(n - 1, k);
        } else {
            // If k is in the second half, it's the opposite of KthGrammar(n-1, k-mid)
            return 1 - KthGrammar(n - 1, k - mid);
        }
    }
}
