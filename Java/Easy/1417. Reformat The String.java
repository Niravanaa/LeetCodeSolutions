class Solution {
    public String reformat(String s) {
        List<Character> letters = new ArrayList<>();
        List<Character> digits = new ArrayList<>();

        // Separate letters and digits
        for (char c : s.toCharArray()) {
            if (Character.isLetter(c)) {
                letters.add(c);
            } else {
                digits.add(c);
            }
        }

        int lettersCount = letters.size();
        int digitsCount = digits.size();

        // Check if reformatting is impossible
        if (Math.abs(lettersCount - digitsCount) > 1) {
            return "";
        }

        // Determine longer and shorter lists
        List<Character> longerList = lettersCount >= digitsCount ? letters : digits;
        List<Character> shorterList = lettersCount < digitsCount ? letters : digits;

        StringBuilder result = new StringBuilder();

        // Interleave characters
        int i = 0;
        while (i < longerList.size() || i < shorterList.size()) {
            if (i < longerList.size()) {
                result.append(longerList.get(i));
            }
            if (i < shorterList.size()) {
                result.append(shorterList.get(i));
            }
            i++;
        }

        return result.toString();
    }
}