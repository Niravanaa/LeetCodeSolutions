public class Solution {
    public string LargestOddNumber(string num) 
    {
        string currentLargest = "";

        for (int i = num.Length - 1; i >= 0; i--) 
        {
            if ((num[i] - '0') % 2 != 0) 
            {
                currentLargest = num.Substring(0, i + 1);
                
                break;
            }
        }

        return currentLargest;
    }
}
