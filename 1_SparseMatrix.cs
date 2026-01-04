using System;

class SparseMatrix {
    static void Main() {
        // Ornek Matris: Cogu elemani 0 olan bir matris
        int[,] matrix = {
            {0, 0, 3, 0, 4},
            {0, 0, 5, 7, 0},
            {0, 0, 0, 0, 0},
            {0, 2, 6, 0, 0}
        };

        Console.WriteLine("--- Sparse Matrix Transformation ---");
        Console.WriteLine("Original Matrix Dimensions: " + matrix.GetLength(0) + "x" + matrix.GetLength(1));
        Console.WriteLine("\nSparse Representation (Row, Col, Value):");
        Console.WriteLine("----------------------------------------");
        
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (matrix[i, j] != 0) {
                    Console.WriteLine($"{i}\t{j}\t{matrix[i, j]}");
                }
            }
        }
    }
}
