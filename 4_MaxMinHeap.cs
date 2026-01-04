using System;

class HeapAlgo {
    static void Main() {
        int[] arr = { 35, 33, 42, 10, 14, 19, 27, 44, 26, 31 };
        Console.WriteLine("Original Array: " + string.Join(", ", arr));
        
        // Min Heap Mantigi (Kucukten buyuge sirali array bir Min-Heap temsilidir)
        Array.Sort(arr);
        Console.WriteLine("\nMin-Heap Representation (Sorted):");
        Console.WriteLine(string.Join(", ", arr));

        // Max Heap Mantigi (Buyukten kucuge sirali array bir Max-Heap temsilidir)
        Array.Reverse(arr);
        Console.WriteLine("\nMax-Heap Representation (Reverse Sorted):");
        Console.WriteLine(string.Join(", ", arr));
    }
}
