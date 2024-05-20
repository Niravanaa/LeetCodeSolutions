class Solution {
    public int[] findMissingAndRepeatedValues(int[][] grid) {
        int[] result = new int[2];
        
        // Using a HashMap instead of Dictionary
        Map<Integer, Integer> numberCount = new HashMap<>();
        
        // Count occurrences of each number
        for (int i = 0; i < grid.length; i++) {
            for (int j = 0; j < grid[i].length; j++) {
                int num = grid[i][j];
                numberCount.put(num, numberCount.getOrDefault(num, 0) + 1);
            }
        }
        
        // Find the repeated value
        for (Map.Entry<Integer, Integer> entry : numberCount.entrySet()) {
            if (entry.getValue() == 2) {
                result[0] = entry.getKey();
                break;
            }
        }
        
        // Find the missing value
        int n = grid.length * grid[0].length;
        for (int i = 1; i <= n; i++) {
            if (!numberCount.containsKey(i)) {
                result[1] = i;
                break;
            }
        }
        
        return result;
    }
}