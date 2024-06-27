using System;

class Program
{
    public static void Main(string[] args)
    {
       
        int[,] matrix = new int[3, 3];
        Console.WriteLine("Enter the 3x3 matrix");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        int col1 = 0; 
        int col3 = 2; 
        
        int rows = matrix.GetLength(0);
        int col = matrix.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            int temp = matrix[i, col1];
            matrix[i, col1] = matrix[i, col3];
            matrix[i, col3] = temp;
        }

        Console.WriteLine("Matrix after interchanging columns:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
  }