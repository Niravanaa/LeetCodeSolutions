public class Solution 
{
    public string LargestGoodInteger(string num) 
    {
        List<int> goodIntegers = new List<int>();

        for (int i = 0; i < num.Length - 2; i++) 
        {
            if (num[i] == num[i + 1] && num[i] == num[i + 2]) 
            {
                goodIntegers.Add(int.Parse(num.Substring(i, 3)));
            }
        }

        if (goodIntegers.Count == 0) 
        {
            return "";
        }

        if (goodIntegers.Max() == 0) 
        {
            return "000";
        }

        int maxGoodInteger = goodIntegers.Max();
        
        return maxGoodInteger.ToString();
    }
}
