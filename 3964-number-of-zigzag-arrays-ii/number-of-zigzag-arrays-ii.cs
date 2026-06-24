public class Solution {
    private const int MOD = 1000000007;

    public int ZigZagArrays(int n, int l, int r) {
        long[,] matrix = new long[r-l, r-l];
        int[] vector = new int[r-l];
        // Build intial vector
        for (int i=l+1; i<=r; i++) {
            vector[i-l-1] = i-l;
        }
        // Build intial Matrix
        for (int i=0; i<r-l; i++) {
            for (int j=0; j<r-l; j++) {
                if (i+j >= r-l-1) matrix[i, j] = 1;
                else matrix[i, j] = 0;
            }
        }
        // Calculate M^(n-1), cuz we built the first vector already
        matrix = MatrixExp(matrix, n-1);
        long ret = 0;
        // Just need to get the last value
        for (int i=0; i<matrix.GetLength(0); i++) {
            ret += (matrix[matrix.GetLength(1)-1, i] * vector[i]);
            if (ret > MOD) ret %= MOD;
        }
        // Problem is completely symmetrical. So we don't need to calculate the other case
        ret *= 2;

        return (int)(ret%MOD);
    }

    // Straightforward matrix multiplication O(k^3)
    public long[,] MatrixMult(long[,] matrix1, long[,] matrix2) {
        int n = matrix1.GetLength(0);
        long[,] ret = new long[n, n];
        for (int i=0; i<n; i++) {
            for (int j=0; j<n; j++) {
                for (int k=0; k<n; k++) {
                    ret[i, j] += matrix1[i, k] * matrix2[k, j];
                    if (ret[i, j] > MOD) ret[i, j] %= MOD;
                }
            }
        }

        return ret;
    }

    // Fast matrix exponentiation in log(n)
    public long[,] MatrixExp(long[,] matrix, int exp) {
        int n = matrix.GetLength(0);
        long[,] ret = new long[n, n];
        // Identity Matrix
        for (int i=0; i<n; i++) {
            ret[i, i] = 1;
        }

        while (exp > 0) {
            if (exp % 2 == 1) {
                ret = MatrixMult(ret, matrix);
            }

            matrix = MatrixMult(matrix, matrix);
            exp /= 2;
        }
        return ret;
    }
}