class Solution {
    public int minDeletionSize(String[] strs) {
        int n = strs.length;
        int m = strs[0].length();
        int deletedColumns = 0;

        for (int j = 0; j < m; j++) {
            for (int i = 0; i < n - 1; i++) {
                if (strs[i].charAt(j) > strs[i + 1].charAt(j)) {
                    deletedColumns++;
                    break; // Move to the next column
                }
            }
        }

        return deletedColumns;
    }
}