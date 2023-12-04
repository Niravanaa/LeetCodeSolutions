public class Solution {
    public int[] FindArray(int[] pref) {
       int[] result = new int[pref.Length];

       result[0] = pref[0];

       int current = result[0];

       for (int i = 1; i < result.Length; i++)
       {
           result[i] = pref[i] ^ current;

           current ^= result[i];
       }

       return result;
    }
}