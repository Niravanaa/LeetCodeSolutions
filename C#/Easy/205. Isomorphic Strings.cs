public class Solution {
    public bool IsIsomorphic(string s, string t) {
        if (s.Length != t.Length)
            return false;

        Dictionary < char, char > lettersf = new Dictionary < char, char > ();
        Dictionary < char, char > lettersb = new Dictionary < char, char > ();

        for (int i = 0; i < s.Length; i++) {
            char charS = s[i];
            char charT = t[i];

            if (lettersf.ContainsKey(charS)) {
                if (lettersf[charS] != charT)
                    return false;
            } else {
                lettersf[charS] = charT;
            }

            if (lettersb.ContainsKey(charT)) {
                if (lettersb[charT] != charS)
                    return false;
            } else {
                lettersb[charT] = charS;
            }
        }

        return true;
    }

}