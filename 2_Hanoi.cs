using System;

class Hanoi {
    // Recursive Cozum
    static void Solve(int n, char from_rod, char to_rod, char aux_rod) {
        if (n == 0) return;
        
        Solve(n - 1, from_rod, aux_rod, to_rod);
        Console.WriteLine($"Move disk {n} from rod {from_rod} to rod {to_rod}");
        Solve(n - 1, aux_rod, to_rod, from_rod);
    }

    static void Main() {
        int n = 3; // Disk sayisi
        Console.WriteLine($"--- Towers of Hanoi Solution for {n} Disks ---");
        Solve(n, 'A', 'C', 'B'); 
    }
}
