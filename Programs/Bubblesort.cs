using System;
class sort
{
    public static void Main(String[] args)
    {
        int[] arr = { 9, 74, 3, 23, 11, 1 };
        // bubble sort
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - 1 - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }

            }
        }
        Console.WriteLine("ASCENDING ORDER USING BUBBLE SORT :: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();

        Console.WriteLine("DECENDING ORDER USING BUBBLE SORT :: ");
        for(int i = arr.Length-1 ; i>=0 ; i--){
            Console.Write(arr[i] + " ");
        }


    }
}