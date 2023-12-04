public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) 
    {
        string concatenatedWord1 = "";

        string concatenatedWord2 = "";

        for (int i = 0; i < word1.Length; i++)
        {
            concatenatedWord1 += word1[i];
        }

        for (int i = 0; i < word2.Length; i++)
        {
            concatenatedWord2 += word2[i];
        }

        return concatenatedWord1.Equals(concatenatedWord2);
    }
}