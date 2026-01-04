using System;

class TreeArray {
    static void Main() {
        // Array representation of a binary tree
        // Eger parent index = i ise;
        // Left Child = 2*i + 1
        // Right Child = 2*i + 2
        char[] tree = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I' };
        
        Console.WriteLine("--- Tree Creation from Array ---");
        Console.WriteLine("Root Node: " + tree[0]);
        
        PrintChildren(tree, 0); // Root'un cocuklari
        PrintChildren(tree, 1); // B'nin cocuklari
        PrintChildren(tree, 2); // C'nin cocuklari
    }

    static void PrintChildren(char[] arr, int i) {
        int left = 2 * i + 1;
        int right = 2 * i + 2;

        if (left < arr.Length)
            Console.WriteLine($"Node {arr[i]} -> Left Child: {arr[left]}");
        else
            Console.WriteLine($"Node {arr[i]} -> Left Child: null");

        if (right < arr.Length)
            Console.WriteLine($"Node {arr[i]} -> Right Child: {arr[right]}");
        else
            Console.WriteLine($"Node {arr[i]} -> Right Child: null");
    }
}
