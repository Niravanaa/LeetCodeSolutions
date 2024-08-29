class Solution:
    def numRookCaptures(self, board: List[List[str]]) -> int:
        def count_pawns_in_direction(x, y, dx, dy):
            while 0 <= x < 8 and 0 <= y < 8:
                if board[x][y] == 'B':
                    return 0
                if board[x][y] == 'p':
                    return 1
                x += dx
                y += dy
            return 0
        
        rook_x, rook_y = -1, -1

        for i in range(8):
            for j in range(8):
                if board[i][j] == 'R':
                    rook_x, rook_y = i, j
            if rook_x != -1:
                break
        
        captures = 0
        captures += count_pawns_in_direction(rook_x - 1, rook_y, -1, 0)  # Up
        captures += count_pawns_in_direction(rook_x + 1, rook_y, 1, 0)   # Down
        captures += count_pawns_in_direction(rook_x, rook_y - 1, 0, -1)  # Left
        captures += count_pawns_in_direction(rook_x, rook_y + 1, 0, 1)   # Right

        return captures