public class Solution {
    public bool IsSubsequence(string s, string t) {
        if (s.Length == 0)
        {
            return true;
        }

        int sPointer = 0;

        int tPointer = 0;

        while (tPointer < t.Length)
        {
            if (s[sPointer] == t[tPointer])
            {
                sPointer++;
            }

            if (sPointer == s.Length)
            {
                return true;
            }
        
            tPointer++;
        }
        
        return false;
    }
}