public class Solution {
    public bool BackspaceCompare(string s, string t)
    {
        int sPointer = s.Length - 1;
        int tPointer = t.Length - 1;
        int sBackspaceCount = 0;
        int tBackspaceCount = 0;

        while (sPointer >= 0 || tPointer >= 0)
        {
            while (sPointer >= 0 && (s[sPointer] == '#' || sBackspaceCount > 0))
            {
                if (s[sPointer] == '#')
                {
                    sBackspaceCount++;
                }

                else
                {
                    sBackspaceCount--;
                }

                sPointer--;
            }

            while (tPointer >= 0 && (t[tPointer] == '#' || tBackspaceCount > 0))
            {
                if (t[tPointer] == '#')
                {
                    tBackspaceCount++;
                }

                else
                {
                    tBackspaceCount--;
                }

                tPointer--;
            }

            if (sPointer >= 0 && tPointer >= 0 && s[sPointer] != t[tPointer])
            {
                return false;
            }

            if ((sPointer >= 0) != (tPointer >= 0))
            {
                return false;
            }

            sPointer--;
            tPointer--;
        }

        return true;
    }
}