public class Solution {
    public int HammingWeight(uint n) {
        string binaryRepresentation = Convert.ToString(n, 2);

        return binaryRepresentation.Count(x => x == '1');
    }
}