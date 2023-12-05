public class Solution {
    public int NumberOfMatches(int n) 
    {
        if (n == 1) { return 0; }
        
        if (n == 2) { return 1; }

        int matches = n / 2;

        n -= matches;

        return matches + NumberOfMatches(n);
    }
}