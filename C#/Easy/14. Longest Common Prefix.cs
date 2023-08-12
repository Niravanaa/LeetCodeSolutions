public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs.Length == 0 || strs[0] == "") {
            return "";
        }

        if (strs.Length == 1) {
            return strs[0];
        }

        Boolean longCheck = false;

        string result = "";

        int currentIndex = 0;

        List < char > characterList = new List < char > ();

        while (!longCheck) {
            if (strs[0].Length < currentIndex + 1) {
                break;
            }

            char currentCharacter = strs[0][currentIndex];

            foreach(string name in strs) {
                if (name.Length < currentIndex + 1) {
                    longCheck = true;
                    break;
                }

                if (currentCharacter != name[currentIndex]) {
                    result = string.Join("", characterList);

                    return result;
                }
            }

            if (longCheck) {
                break;
            }

            characterList.Add(currentCharacter);

            currentIndex++;
        }

        result = string.Join("", characterList);

        return result;
    }
}