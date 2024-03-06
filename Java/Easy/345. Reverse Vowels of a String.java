class Solution {
    public String reverseVowels(String s) {
        int pointer1 = 0;
        int pointer2 = s.length() - 1;
        char temp;

        List<Character> vowels = new ArrayList<Character>();
        vowels.add('a');
        vowels.add('e');
        vowels.add('i');
        vowels.add('o');
        vowels.add('u');

        // Convert string to char array for better manipulation
        char[] chars = s.toCharArray();

        while (pointer1 < pointer2) {
            // Find the first vowel from the left
            while (pointer1 < pointer2 && !vowels.contains(Character.toLowerCase(chars[pointer1])))
                pointer1++;

            // Find the first vowel from the right
            while (pointer1 < pointer2 && !vowels.contains(Character.toLowerCase(chars[pointer2])))
                pointer2--;

            // Swap vowels
            if (pointer1 < pointer2) {
                temp = chars[pointer1];
                chars[pointer1] = chars[pointer2];
                chars[pointer2] = temp;
                pointer1++;
                pointer2--;
            }
        }

        // Convert char array back to string
        return new String(chars);
    }
}