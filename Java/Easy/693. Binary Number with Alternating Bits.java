class Solution {
    public boolean hasAlternatingBits(int n) {
        // Get the last bit
        int lastBit = n & 1;
        n = n >> 1; // Right shift to process the next bit

        while (n > 0) {
            // Get the current bit
            int currentBit = n & 1;
            
            // Check if the current bit is the same as the last bit
            if (currentBit == lastBit) {
                return false;
            }
            
            // Update lastBit to currentBit for next iteration
            lastBit = currentBit;
            
            // Right shift to process the next bit
            n = n >> 1;
        }
        
        return true;
    }
}