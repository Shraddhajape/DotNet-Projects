using System;
class hello{
    public static void Main(string[] args){
        int size;
        Console.WriteLine("ENTER ARRAY SIZE :: ");
        size = Convert.ToInt32(Console.ReadLine());
        int [] array = new int[size];
        Console.WriteLine("ENTER ARRAY ELEMENTS :: ");
        for(int i = 0; i < size ; i++){
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("ARRAY ELEMENTS ARE :: ");
        for(int i = 0; i < size ; i++){
            Console.Write(array[i]+ " ");
        }
        Console.WriteLine();

        Console.WriteLine("REVERSED ARRAY ELEMENTS ARE :: ");
        int [] newArray = new int[size];
        for(int i = size-1; i >=0 ; i--){
            Console.Write(array[i] + " ");
        }

    }
}