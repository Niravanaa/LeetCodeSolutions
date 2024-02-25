class Solution {
    public int countPrefixSuffixPairs(String[] words) {
        int count = 0;
        
        for (int i = 0; i < words.length; i++) {
            String word1 = words[i];
            for (int j = i + 1; j < words.length; j++) {
                String word2 = words[j];
                
                if (isPrefixAndSuffix(word1, word2)) {
                    count++;
                }
            }
        }
        
        return count;
    }
    
    public static boolean isPrefixAndSuffix(String str1, String str2) {
        int len1 = str1.length();
        int len2 = str2.length();
        
        if (len1 > len2) {
            return false;
        }
        
        String prefix = str2.substring(0, len1);
        String suffix = str2.substring(len2 - len1);
        
        return prefix.equals(str1) && suffix.equals(str1);
    }
}