using System;

class GraphCluster {
    // 8 komsulu (sag, sol, yukari, asagi, caprazlar) kontrolu
    static void DFS(int[,] M, int r, int c, int R, int C, bool[,] visited) {
        int[] rowNbr = { -1, -1, -1, 0, 0, 1, 1, 1 };
        int[] colNbr = { -1, 0, 1, -1, 1, -1, 0, 1 };

        visited[r, c] = true;

        for (int k = 0; k < 8; ++k)
            if (IsSafe(M, r + rowNbr[k], c + colNbr[k], R, C, visited))
                DFS(M, r + rowNbr[k], c + colNbr[k], R, C, visited);
    }

    static bool IsSafe(int[,] M, int r, int c, int R, int C, bool[,] visited) {
        return (r >= 0) && (r < R) && (c >= 0) && (c < C) && (M[r, c] == 1 && !visited[r, c]);
    }

    static void Main() {
        // 1'ler bagli dugumleri, 0'lar boslugu temsil eder
        int[,] M = { 
            {1, 1, 0, 0, 0},
            {0, 1, 0, 0, 1},
            {1, 0, 0, 1, 1},
            {0, 0, 0, 0, 0},
            {1, 0, 1, 0, 1} 
        };
        int R = 5, C = 5;
        bool[,] visited = new bool[R, C];
        int count = 0;
        
        for (int i = 0; i < R; ++i)
            for (int j = 0; j < C; ++j)
                if (M[i, j] == 1 && !visited[i, j]) {
                    DFS(M, i, j, R, C, visited);
                    ++count;
                }
        
        Console.WriteLine("--- Graph Clustering (Number of Islands) ---");
        Console.WriteLine("Number of clusters found: " + count);
    }
}
