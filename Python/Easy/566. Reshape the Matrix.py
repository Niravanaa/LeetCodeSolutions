class Solution:
    def matrixReshape(self, mat: List[List[int]], r: int, c: int) -> List[List[int]]:
        m = len(mat)
        n = len(mat[0]) if mat else 0

        if m * n != r * c:
            return mat
        
        flat = [item for sublist in mat for item in sublist]

        new_mat = []
        for i in range(r):
            new_mat.append(flat[i * c:(i + 1) * c])
        
        return new_mat