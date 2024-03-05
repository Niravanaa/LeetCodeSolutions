class Solution {
    public int hammingDistance(int x, int y) {
        // Convert integers to binary strings
        String bin1 = Integer.toBinaryString(x);
        String bin2 = Integer.toBinaryString(y);

        // Ensure both binary strings have the same length by padding with leading zeros
        int maxLength = Math.max(bin1.length(), bin2.length());
        bin1 = String.format("%" + maxLength + "s", bin1).replace(' ', '0');
        bin2 = String.format("%" + maxLength + "s", bin2).replace(' ', '0');

        // Count the number of positions where the bits are different
        int count = 0;
        for (int i = 0; i < maxLength; i++) {
            if (bin1.charAt(i) != bin2.charAt(i)) {
                count++;
            }
        }

        return count;
    }
}