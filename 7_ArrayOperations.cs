using System;
using System.Collections.Generic;

class ArrayOps {
    static void Main() {
        // C# dilinde statik Array'e ekleme yapilamaz, List kullanilir.
        // Bu ornek Array mantigini List uzerinden gosterir.
        
        List<int> numbers = new List<int>() { 10, 20, 30, 40, 50 };
        Console.WriteLine("Initial Array: " + string.Join(", ", numbers));

        // Ekleme (Insertion)
        Console.WriteLine("\nInserting 99 at the end...");
        numbers.Add(99);
        Console.WriteLine("Result: " + string.Join(", ", numbers));

        // Araya Ekleme
        Console.WriteLine("\nInserting 25 at index 2...");
        numbers.Insert(2, 25);
        Console.WriteLine("Result: " + string.Join(", ", numbers));

        // Silme (Deletion)
        Console.WriteLine("\nDeleting value 40...");
        numbers.Remove(40);
        Console.WriteLine("Result: " + string.Join(", ", numbers));
    }
}
