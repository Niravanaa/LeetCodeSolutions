class Solution {
    public boolean isRectangleOverlap(int[] rec1, int[] rec2) {
        // Check if one rectangle is to the right of the other
        // rec1[0] is the left x-coordinate of the first rectangle
        // rec2[2] is the right x-coordinate of the second rectangle
        boolean noOverlapRight = rec1[0] >= rec2[2];
        
        // Check if one rectangle is above the other
        // rec1[1] is the bottom y-coordinate of the first rectangle
        // rec2[3] is the top y-coordinate of the second rectangle
        boolean noOverlapAbove = rec1[1] >= rec2[3];
        
        // Check if one rectangle is to the left of the other
        // rec1[2] is the right x-coordinate of the first rectangle
        // rec2[0] is the left x-coordinate of the second rectangle
        boolean noOverlapLeft = rec1[2] <= rec2[0];
        
        // Check if one rectangle is below the other
        // rec1[3] is the top y-coordinate of the first rectangle
        // rec2[1] is the bottom y-coordinate of the second rectangle
        boolean noOverlapBelow = rec1[3] <= rec2[1];
        
        // If any of the conditions for non-overlapping are true, the rectangles do not overlap
        return !(noOverlapRight || noOverlapAbove || noOverlapLeft || noOverlapBelow);
    }
}
