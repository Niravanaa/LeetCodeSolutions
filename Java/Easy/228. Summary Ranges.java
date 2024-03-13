class Solution {
    public List<String> summaryRanges(int[] nums) {
        List<String> ranges = new ArrayList<>();
        if (nums == null || nums.length == 0) {
            return ranges;
        }
        
        int start = nums[0];
        int end = nums[0];
        
        for (int i = 1; i < nums.length; i++) {
            if (nums[i] == end + 1) {
                // Extend the current range
                end = nums[i];
            } else {
                // Close the current range and start a new one
                if (start == end) {
                    ranges.add(String.valueOf(start));
                } else {
                    ranges.add(start + "->" + end);
                }
                start = nums[i];
                end = nums[i];
            }
        }
        
        // Add the last range
        if (start == end) {
            ranges.add(String.valueOf(start));
        } else {
            ranges.add(start + "->" + end);
        }
        
        return ranges;
    }
}