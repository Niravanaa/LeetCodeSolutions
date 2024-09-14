MOD = 10**9 + 7

class Solution:
    # Helper function to compute factorial modulo MOD
    def factorial_mod(self, n, MOD):
        result = 1
        for i in range(2, n+1):
            result = result * i % MOD
        return result

    # Sieve of Eratosthenes to find prime numbers up to n
    def sieve_of_eratosthenes(self, n):
        is_prime = [True] * (n + 1)
        is_prime[0] = is_prime[1] = False
        for i in range(2, int(n**0.5) + 1):
            if is_prime[i]:
                for j in range(i * i, n + 1, i):
                    is_prime[j] = False
        return is_prime

    def numPrimeArrangements(self, n: int) -> int:
        # Step 1: Get prime status up to n using Sieve of Eratosthenes
        is_prime = self.sieve_of_eratosthenes(n)
        
        # Step 2: Count prime indices (1-indexed)
        prime_count = sum(is_prime[i] for i in range(1, n + 1))
        
        # Step 3: Calculate the number of non-prime indices
        non_prime_count = n - prime_count
        
        # Step 4: Calculate factorial for both prime_count and non_prime_count modulo MOD
        prime_factorial = self.factorial_mod(prime_count, MOD)
        non_prime_factorial = self.factorial_mod(non_prime_count, MOD)
        
        # Step 5: Multiply both factorials and take modulo MOD
        return prime_factorial * non_prime_factorial % MOD