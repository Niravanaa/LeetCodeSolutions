class Solution {
    public String removeDuplicates(String s) {
        StringBuilder result = new StringBuilder();

        for (char c : s.toCharArray()) {
            if (result.length() > 0 && c == result.charAt(result.length() - 1)) {
                // Skip if current character is a duplicate
                result.deleteCharAt(result.length() - 1);
            } else {
                // Append current character to result
                result.append(c);
            }
        }

        return result.toString();
    }
}