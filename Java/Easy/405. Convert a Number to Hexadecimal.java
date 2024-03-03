class Solution {
    public String toHex(int num) {
        if (num == 0) {
            return "0";
        }
        
        StringBuilder hexString = new StringBuilder();
        int mask = 0xF; // Mask to extract 4 bits
        
        while (num != 0) {
            int remainder = num & mask;
            char digit = (char) (remainder < 10 ? remainder + '0' : remainder + 'a' - 10);
            hexString.insert(0, digit);
            num >>>= 4; // Unsigned right shift by 4 bits
        }
        
        return hexString.toString();
    }
}