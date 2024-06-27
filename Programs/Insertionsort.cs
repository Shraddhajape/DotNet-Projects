using System;
class sort
{
    public static void Main(String[] args)
    {
        int[] arr = { 9, 74, 3, 23, 11, 1 };
        // insertion sort

        for(int i = 1; i < arr.Length; i++){
            int current = arr[i];
            int j = i-1;
            while( j >=0 && current < arr[j]){
                arr[j+1] = arr[j];
                j--;
            }

            arr[j+1] = current;
        }
        
        Console.WriteLine("ASCENDING ORDER USING INSERTION SORT :: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();

        Console.WriteLine("DECENDING ORDER USING INSERTION SORT :: ");
        for(int i = arr.Length-1 ; i>=0 ; i--){
            Console.Write(arr[i] + " ");
        }

    }
}