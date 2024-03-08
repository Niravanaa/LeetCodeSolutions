
class Solution {
    public int divisorSubstrings(int num, int k) {
        String numString = Integer.toString(num);
        int n = numString.length();
        Set<Integer> divisors = findDivisors(num);
        int beautyCount = 0;

        for (int i = 0; i <= n - k; i++) {
            String substring = numString.substring(i, i + k);
            int subNum = Integer.parseInt(substring);
            if (divisors.contains(subNum)) {
                beautyCount++;
            }
        }

        return beautyCount;
    }

    // Function to find divisors of a number
    public static Set<Integer> findDivisors(int num) {
        Set<Integer> divisors = new HashSet<>();
        for (int i = 1; i <= Math.sqrt(num); i++) {
            if (num % i == 0) {
                divisors.add(i);
                divisors.add(num / i);
            }
        }
        return divisors;
    }
}