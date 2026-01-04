using System;
using System.Collections.Generic;

class GraphTraversal {
    private int V; // Vertex sayisi
    private List<int>[] adj; // Adjacency List

    GraphTraversal(int v) {
        V = v;
        adj = new List<int>[v];
        for (int i = 0; i < v; ++i)
            adj[i] = new List<int>();
    }

    void AddEdge(int v, int w) { adj[v].Add(w); }

    void BFS(int s) {
        bool[] visited = new bool[V];
        Queue<int> queue = new Queue<int>();

        visited[s] = true;
        queue.Enqueue(s);

        Console.Write("BFS: ");
        while (queue.Count != 0) {
            s = queue.Dequeue();
            Console.Write(s + " ");

            foreach (int n in adj[s]) {
                if (!visited[n]) {
                    visited[n] = true;
                    queue.Enqueue(n);
                }
            }
        }
        Console.WriteLine();
    }

    void DFSUtil(int v, bool[] visited) {
        visited[v] = true;
        Console.Write(v + " ");
        foreach (int n in adj[v])
            if (!visited[n]) DFSUtil(n, visited);
    }

    void DFS(int v) {
        Console.Write("DFS: ");
        bool[] visited = new bool[V];
        DFSUtil(v, visited);
        Console.WriteLine();
    }

    static void Main() {
        GraphTraversal g = new GraphTraversal(4);
        g.AddEdge(0, 1); g.AddEdge(0, 2);
        g.AddEdge(1, 2); g.AddEdge(2, 0);
        g.AddEdge(2, 3); g.AddEdge(3, 3);

        Console.WriteLine("--- Graph Traversals (Starting from vertex 2) ---");
        g.BFS(2);
        g.DFS(2);
    }
}
