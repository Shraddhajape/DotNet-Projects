using System;

class Program
{
    public static void Main(string[] args)
    {
        int[,] matrix = new int[3, 3];
        Console.WriteLine("Enter the 3x3 matrix:");
        
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }

        }

        int row1 = 0; 
        int row3 = 2; 
        int col = matrix.GetLength(1);
        for (int j = 0; j < col; j++)
        {
            int temp = matrix[row1, j];
            matrix[row1, j] = matrix[row3, j];
            matrix[row3, j] = temp;
        }

        Console.WriteLine("Matrix after interchanging rows:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < col; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}