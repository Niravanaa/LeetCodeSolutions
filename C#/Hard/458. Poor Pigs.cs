public class Solution {
    public int PoorPigs(int buckets, int minutesToDie, int minutesToTest) {
        int pigs = 0;
        int states = minutesToTest / minutesToDie + 1;
        
        while (Math.Pow(states, pigs) < buckets) {
            pigs++;
        }
        
        return pigs;
    }
}