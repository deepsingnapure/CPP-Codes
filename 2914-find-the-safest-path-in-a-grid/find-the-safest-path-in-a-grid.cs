public class Solution {
    public int MaximumSafenessFactor(IList<IList<int>> grid)
        {
            int n = grid.Count;
            if (grid[0][0] == 1 || grid[n - 1][n - 1] == 1)
            {
                return 0;
            }
            Queue<int[]> q = new Queue<int[]>();
            int[][] dist = new int[n][];
            for (int i = 0; i < n; ++i)
            {
                dist[i] = new int[n];
                for (int j = 0; j < n; ++j)
                {
                    dist[i][j] = int.MaxValue;
                }
            }
            int[] dirs = { -1, 0, 1, 0, -1 };
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (grid[i][j] == 1)
                    {
                        dist[i][j] = 0;
                        q.Enqueue(new int[] { i, j });
                    }
                }
            }
            while (q.Count > 0)
            {
                int[] p = q.Dequeue();
                int i = p[0], j = p[1];
                for (int k = 0; k < 4; ++k)
                {
                    int x = i + dirs[k], y = j + dirs[k + 1];
                    if (x >= 0 && x < n && y >= 0 && y < n && dist[x][y] == int.MaxValue)
                    {
                        dist[x][y] = dist[i][j] + 1;
                        q.Enqueue(new int[] { x, y });
                    }
                }
            }
            List<int[]> t = new List<int[]>();
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    t.Add(new int[] { dist[i][j], i, j });
                }
            }
            t.Sort((a, b) => b[0].CompareTo(a[0]));
            UnionFind uf = new UnionFind(n * n);
            foreach (int[] p in t)
            {
                int d = p[0], i = p[1], j = p[2];
                for (int k = 0; k < 4; ++k)
                {
                    int x = i + dirs[k], y = j + dirs[k + 1];
                    if (x >= 0 && x < n && y >= 0 && y < n && dist[x][y] >= d)
                    {
                        uf.Union(i * n + j, x * n + y);
                    }
                }
                if (uf.Find(0) == uf.Find(n * n - 1))
                {
                    return d;
                }
            }
            return 0;
        }
    }

    public class UnionFind
    {
        private int[] p;
        private int n;

        public UnionFind(int n)
        {
            p = new int[n];
            for (int i = 0; i < n; ++i)
            {
                p[i] = i;
            }
            this.n = n;
        }

        public bool Union(int a, int b)
        {
            int pa = Find(a);
            int pb = Find(b);
            if (pa == pb)
            {
                return false;
            }
            p[pa] = pb;
            --n;
            return true;
        }

        public int Find(int x)
        {
            if (p[x] != x)
            {
                p[x] = Find(p[x]);
            }
            return p[x];
        }
    }