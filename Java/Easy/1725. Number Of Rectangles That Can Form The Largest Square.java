class Solution {
    public int countGoodRectangles(int[][] rectangles) {
        int result = -1;

        int number = 0;

        for (int i = 0; i < rectangles.length; i++)
        {
            int smallestSquare = Math.min(rectangles[i][0], rectangles[i][1]);

            result = Math.max(result, smallestSquare);
        }

        for (int i = 0; i < rectangles.length; i++)
        {
            int smallestSquare = Math.min(rectangles[i][0], rectangles[i][1]);

            if (result <= smallestSquare)
            {
                number++;
            }
        }

        return number;
    }
}