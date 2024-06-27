using System;

class Program
{
    static void Main()
    {
        // Initialize a 3x3 matrix
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        // Get the number of rows and columns in the matrix
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Create a new matrix to hold the transposed values
        int[,] transposedMatrix = new int[cols, rows];

        // Transpose the matrix
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                // Assign the value to the transposed matrix
                transposedMatrix[j, i] = matrix[i, j];
            }
        }

        // Print the transposed matrix
        Console.WriteLine("Transposed Matrix:");
        for (int i = 0; i < cols; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                Console.Write(transposedMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
