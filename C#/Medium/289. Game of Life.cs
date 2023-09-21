public class Solution {
    public void GameOfLife(int[][] board) {
        // Get the number of rows and columns in the board.
        int rows = board.Length;
        int cols = board[0].Length;

        // Create a copy of the board to store the updated cell states.
        int[][] copyBoard = new int[rows][];
        for (int i = 0; i < rows; i++) {
            copyBoard[i] = new int[cols];
            // Copy the cell values from the original board to the copy board.
            Array.Copy(board[i], copyBoard[i], cols);
        }

        // Define arrays for horizontal and vertical neighbors' offsets.
        int[] dx = { -1, -1, -1, 0, 0, 1, 1, 1 };
        int[] dy = { -1, 0, 1, -1, 1, -1, 0, 1 };

        // Iterate through each cell in the board.
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                // Count the number of live neighbors for the current cell.
                int liveNeighbors = 0;
                for (int k = 0; k < 8; k++) {
                    int x = i + dx[k];
                    int y = j + dy[k];

                    // Check if the neighbor is within bounds and alive.
                    if (x >= 0 && x < rows && y >= 0 && y < cols && copyBoard[x][y] == 1) {
                        liveNeighbors++;
                    }
                }

                // Apply the rules of the Game of Life to update the cell state.
                if (copyBoard[i][j] == 1 && (liveNeighbors < 2 || liveNeighbors > 3)) {
                    // Cell dies due to underpopulation or overpopulation.
                    board[i][j] = 0;
                } else if (copyBoard[i][j] == 0 && liveNeighbors == 3) {
                    // Cell becomes alive due to reproduction.
                    board[i][j] = 1;
                }
            }
        }
    }
}
