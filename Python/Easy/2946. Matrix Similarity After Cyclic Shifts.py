class Solution:
    def areSimilar(self, mat: List[List[int]], k: int) -> bool:
        def shift_left(row, steps):
            steps = steps % len(row)
            return row[steps:] + row[:steps]

        def shift_right(row, steps):
            steps = steps % len(row)
            return row[-steps:] + row[:-steps]

        m, n = len(mat), len(mat[0])

        original = [row[:] for row in mat]

        for i in range(m):
            if i % 2 == 0:
                mat[i] = shift_left(mat[i], k)
            else:
                mat[i] = shift_right(mat[i], k)
        
        return mat == original