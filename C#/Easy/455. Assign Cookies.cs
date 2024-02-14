public class Solution {
    public int FindContentChildren(int[] g, int[] s) {
        Array.Sort(g);
        Array.Sort(s);
        
        int contentChildren = 0;
        int gIndex = 0;
        int sIndex = 0;
        
        while (gIndex < g.Length && sIndex < s.Length) {
            if (s[sIndex] >= g[gIndex]) {
                contentChildren++;
                gIndex++;
            }
            sIndex++;
        }
        
        return contentChildren;
    }
}
