public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        // Create a dictionary to store the groups of anagrams
        Dictionary<string, List<string>> anagramGroups = new Dictionary<string, List<string>>();

        // Iterate through each word in the array
        foreach (string word in strs)
        {
            // Sort the characters in the word to create a key
            char[] charArray = word.ToCharArray();
            Array.Sort(charArray);
            string sortedWord = new string(charArray);

            // Check if the key exists in the dictionary
            // If not, add it with a new list containing the word
            if (!anagramGroups.ContainsKey(sortedWord))
            {
                anagramGroups[sortedWord] = new List<string> { word };
            }
            else
            {
                // If the key already exists, add the word to the corresponding list
                anagramGroups[sortedWord].Add(word);
            }
        }

        // Convert the values of the dictionary to a list of lists and return the result
        return new List<IList<string>>(anagramGroups.Values);
    }
}