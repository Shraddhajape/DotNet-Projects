using System;

public class Hello
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter element to search in array :: ");
        int element = Convert.ToInt32(Console.ReadLine());

        int[,] array = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        bool isFound = false;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (element == array[i, j])
                {
                    isFound = true;
                    break;
                }
            }
            if (isFound)
            {
                break;
            }
        }

        if (isFound)
        {
            Console.WriteLine("Element Found: " + element);
        }
        else
        {
            Console.WriteLine("Element Not Found: " + element);
        }
    }
}
