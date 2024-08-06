class Solution:
    def uniqueMorseRepresentations(self, words: List[str]) -> int:
        morse_alphabet = [".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."]
        
        # Create a mapping from letters to their Morse code
        alphabet = "abcdefghijklmnopqrstuvwxyz"
        morse_dict = {letter: code for letter, code in zip(alphabet, morse_alphabet)}
        
        # Create a set to store unique transformations
        unique_transformations = set()
        
        for word in words:
            morse_word = ''.join(morse_dict[letter] for letter in word)
            unique_transformations.add(morse_word)
        
        return len(unique_transformations)
