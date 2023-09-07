public class Solution {
    public int MaxArea(int[] height) {
        int maxArea = 0;
        int left = 0;
        int right = height.Length - 1;

        while (left < right)
        {
            int h = Math.Min(height[left], height[right]);
            int w = right - left;
            int area = h * w;
            maxArea = Math.Max(maxArea, area);

            if (height[left] < height[right])
            {
                left++;
            }

            else
            {
                right--;
            }
        }

        return maxArea;
    }
}