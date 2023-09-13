public class Solution {
    public bool IsValidSudoku(char[][] board) {
        // Arrays to keep track of seen digits in rows, columns, and sub-grids.
        bool[][] seenInRow = new bool[9][];
        bool[][] seenInColumn = new bool[9][];
        bool[][] seenInSubgrid = new bool[9][];
        
        for (int i = 0; i < 9; i++) {
            seenInRow[i] = new bool[9];
            seenInColumn[i] = new bool[9];
            seenInSubgrid[i] = new bool[9];
        }
        
        // Iterate through the board.
        for (int row = 0; row < 9; row++) {
            for (int col = 0; col < 9; col++) {
                char currentChar = board[row][col];
                if (currentChar != '.') {
                    int digit = currentChar - '1'; // Convert char to digit
                    
                    // Check if the digit is already seen in the current row, column, or sub-grid.
                    if (seenInRow[row][digit] || seenInColumn[col][digit] || seenInSubgrid[row / 3 * 3 + col / 3][digit]) {
                        return false; // Duplicate digit found
                    }
                    
                    // Mark the digit as seen.
                    seenInRow[row][digit] = true;
                    seenInColumn[col][digit] = true;
                    seenInSubgrid[row / 3 * 3 + col / 3][digit] = true;
                }
            }
        }
        
        return true; // No duplicate digits found, the board is valid.
    }
}
