using System;
class program{
    public static void Main(string[] args){
        Console.WriteLine("ENTER SIZE FOR SERIES :: ");
        int size = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("FIBONACCI SERIES IS :: ");
        for(int i = 0; i < size; i++){
            Console.WriteLine(fibonacci(i)+" ");
        }
    }
    static int fibonacci(int num){
        if(num <= 1){
            return num;
        }
        else{
            return fibonacci(num-1)+fibonacci(num-2);
        }
    }
    
}