public class Solution {
    public string LargestMerge(string word1, string word2) {
        int firstPointer = 0;

        int secondPointer = 0;

        string result = "";

        while (firstPointer < word1.Length && secondPointer < word2.Length)
        {
            if (word1[firstPointer] < word2[secondPointer])
            {
                result += word2[secondPointer];

                secondPointer++;
            }

            else if (word2[secondPointer] < word1[firstPointer])
            {
                result += word1[firstPointer];

                firstPointer++;
            }

            else
            {
                if (word1.Substring(firstPointer).CompareTo(word2.Substring(secondPointer)) > 0) 
                {
                    result += word1[firstPointer];

                    firstPointer++;
                } 
                
                else 
                {
                    result += word2[secondPointer];
                    
                    secondPointer++;
                }
            }
        }

        if (firstPointer != word1.Length)
        {
            result += word1.Substring(firstPointer, word1.Length - firstPointer);
        }

        else
        {
            result += word2.Substring(secondPointer, word2.Length - secondPointer);
        }

        return result;
    }
}