class Solution:
    def judgeCircle(self, moves: str) -> bool:
        x = 0
        y = 0

        for letter in moves:
            if letter == 'U':
                x = x + 1
            if letter == 'D':
                x = x - 1
            if letter == 'L':
                y = y - 1
            if letter == 'R':
                y = y + 1
        
        return (x is 0 and y is 0)