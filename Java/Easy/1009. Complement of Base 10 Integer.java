class Solution {
    public int bitwiseComplement(int n) {
        // Special case: if n is 0, the complement is 1
        if (n == 0) {
            return 1;
        }

        // Count the number of bits required to represent n
        int numBits = (int) (Math.log(n) / Math.log(2)) + 1;

        // Calculate the bitmask for the complement
        int bitmask = (1 << numBits) - 1;

        // Return the complement of n
        return bitmask ^ n;
    }
}